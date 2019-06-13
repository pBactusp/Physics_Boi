#include <TimerOne.h>
#include "Sensors.h"

#define SERIAL_RATE 1000000
#define SENSORS_NUM 6

// Errors:
//
// 0 | sBuffer overflow
// 1 | 
// 2 | 
int Error = -1;
const int ERROR_LED = 10;

// String Data Buffer:
const int sBuffer_length = 10;
String sBuffer[sBuffer_length];
int sBuffer_sIndex;
int sBuffer_wIndex;


bool GettingData = false;

int arg[4];

int sensor_num;
Sensor *sensors[SENSORS_NUM];

const int debug_pin = 12;
bool led_is_on = false;
unsigned long start_millis;
unsigned long tempMillis;


void HandleError()
{
  if (Error != -1)
  {
    digitalWrite(ERROR_LED, HIGH);
  }
  
}



void setup()
{
  //noInterrupts();
  
  sBuffer_sIndex = 0;
  sBuffer_wIndex = 0;


  GettingData = false;
  pinMode(debug_pin, OUTPUT);
  pinMode(ERROR_LED, OUTPUT);

  Serial.begin(SERIAL_RATE);

  for (int i = 0; i < SENSORS_NUM; i++)
  {
    sensors[i] = new Sensor(0, i);
  }
  
  while (Serial.available() > 0)
    Serial.read();
}

void loop() 
{ 

  HandleError();

  
  if (Serial.available() > 0)
  {
    ReadCommand(); 
  }

  if (GettingData)
    ReactivateInterruptedSensors();

  Send_sBuffer();
  //delay(10);
}


void ReactivateInterruptedSensors()
{
  for (int i = 0; i < SENSORS_NUM; i++)
    if (sensors[i]->Interrupted && ((micros() - sensors[i]->LastSampleTime) >= sensors[i]->SamplePeriod * 1000))
    {
      sensors[i]->Activate();

      switch (sensors[i]->Type)
      {
        case 2:
        case 3:
        case 4:
        case 5:
          Add_sBuffer(String(sensors[i]->Con->Num) + "," + String(sensors[i]->Value) + "," + String(millis() - start_millis));
        break;

        default:
          break;
      }
    }
    
}


void Send_sBuffer()
{
  while (sBuffer_sIndex != sBuffer_wIndex)
  {
    Serial.println(sBuffer[sBuffer_sIndex]);
    
    sBuffer_sIndex++;
    if (sBuffer_sIndex >= sBuffer_length)
      sBuffer_sIndex = 0;
  }
}
void Add_sBuffer(String s)
{
  sBuffer[sBuffer_wIndex] = s;
  
  sBuffer_wIndex++;
  if (sBuffer_wIndex >= sBuffer_length)
      sBuffer_wIndex = 0;
      
  if (sBuffer_wIndex == sBuffer_sIndex)
  {
        Error = 0;
        return;
  }

}


void ReadCommand()
{
    String command = Serial.readString();
    
    if (command.substring(0, 5) == "marco")
    {
      //Serial.println("polo");
    }
    else if (command.substring(0, 5) == "start")
    {
      start_millis = millis();
      GettingData = true;
      
      if (sensors[0]->Type == 1)
      {
        digitalWrite(2, HIGH);
        attachInterrupt(digitalPinToInterrupt(2), Interrupt_Pin2, FALLING);
      }
      if (sensors[1]->Type == 1)
      {
        digitalWrite(3, HIGH);
        attachInterrupt(digitalPinToInterrupt(3), Interrupt_Pin3, FALLING);
      }  
      if (sensors[2]->Type == 1)
      {
        digitalWrite(18, HIGH);
        attachInterrupt(digitalPinToInterrupt(18), Interrupt_Pin18, FALLING);
      }  
      if (sensors[3]->Type == 1)
      {
        digitalWrite(19, HIGH);
        attachInterrupt(digitalPinToInterrupt(19), Interrupt_Pin19, FALLING);
      }  
      if (sensors[4]->Type == 1)
      {
        digitalWrite(20, HIGH);
        attachInterrupt(digitalPinToInterrupt(20), Interrupt_Pin20, FALLING);
      }  
      if (sensors[5]->Type == 1)
      {
        digitalWrite(21, HIGH);
        attachInterrupt(digitalPinToInterrupt(21), Interrupt_Pin21, FALLING);
      }  
      
      for (int i = 0; i < SENSORS_NUM; i++)
      {
        sensors[i]->Activate();
      }
      
    }
    else if (command.substring(0, 4) == "stop")
    {
      detachInterrupt(digitalPinToInterrupt(2));
      detachInterrupt(digitalPinToInterrupt(3));
      detachInterrupt(digitalPinToInterrupt(18));
      detachInterrupt(digitalPinToInterrupt(19));
      detachInterrupt(digitalPinToInterrupt(20));
      detachInterrupt(digitalPinToInterrupt(21));
      
      GettingData = false;

      ClearSensors();
      digitalWrite(debug_pin, LOW);
    }
    else if (command.substring(0, 6) == "sensor")
    {
      int arg_count = SplitString(command.substring(7));
      //for (int i = 0; i < arg_count; i++)
      //  Serial.println(arg[i]);
        
      sensors[arg[1]]->Set(arg[0], arg[2]);
    }
    else if (command.substring(0, 11) == "ShowSensors")
    {
      for (int i = 0; i < SENSORS_NUM; i++)
        Serial.println(String(sensors[i]->Type) + " | " + String(sensors[i]->Con->Num));
    }

    Serial.println("ok");
}


void ClearSensors()
{
  for(int i = 0; i < SENSORS_NUM; i++)
    sensors[i]->Type = 0;
}

Sensor* ReadSensor()
{
  int type = Serial.read();
  int con = Serial.read();
    

  Sensor *ret = new Sensor(type, con);
  
  return ret;
}


void Interrupt_Pin2()
{
  digitalWrite(2, HIGH);
  Interrupt_General(0);
}
void Interrupt_Pin3()
{
  digitalWrite(3, HIGH);
  Interrupt_General(1);
}
void Interrupt_Pin21()
{
  digitalWrite(21, HIGH);
  Interrupt_General(5);
}
void Interrupt_Pin20()
{
  digitalWrite(20, HIGH);
  Interrupt_General(4);
}
void Interrupt_Pin19()
{
  digitalWrite(19, HIGH);
  Interrupt_General(3);
}
void Interrupt_Pin18()
{
   digitalWrite(18, HIGH);
  Interrupt_General(2);
}

void Interrupt_General(int num)
{
  if (GettingData && !sensors[num]->Interrupted) // && digitalRead(sensors[num]->Con->interruptPin) == HIGH)
  {
    sensors[num]->Interrupted = true;
    
    switch (sensors[num]->Type)
    {
      case 1:
          
        Add_sBuffer(String(num) + "," + String(micros() - sensors[num]->LastSampleTime) + "," + String(millis() - start_millis));   
        break;
  
      default:
        break;
    }
  }
  
  if (led_is_on)
    digitalWrite(debug_pin, LOW);
  else
    digitalWrite(debug_pin, HIGH);
  led_is_on = !led_is_on;
  
  //Serial.println(num);
}


void LedBlink(int x)
{
  for (; x > 0; x--)
  {
    digitalWrite(debug_pin, HIGH);
    delay(100);
    digitalWrite(debug_pin, LOW);
    delay(100);
  }
}

int SplitString(String s)
{
  int i = s.indexOf(',');
  int arg_index = 0;
  
  while ( i > -1)
  {
    arg[arg_index++] = s.substring(0, i).toInt();
    s = s.substring(i + 1);

    i = s.indexOf(',');
  }

  arg[arg_index] = s.toInt();

  return arg_index + 1;
}
