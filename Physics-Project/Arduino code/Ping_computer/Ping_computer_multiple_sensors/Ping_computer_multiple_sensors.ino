#include <TimerOne.h>
#include "Sensors.h"

#define SERIAL_RATE 500000


// String Data Buffer:
string sBuffer[10];
int sBuffer_sIndex;
int sBuffer_wIndex;


bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;

int sensor_num;
Sensor *sensors[6];

const int debug_pin = 12;
bool led_is_on = false;
int start_millis;

void setup()
{
  sBuffer_sIndex = 0;
  sBuffer_wIndex = 0;

  
  GettingData = true;
  pinMode(debug_pin, OUTPUT);

  attachInterrupt(digitalPinToInterrupt(2), Interrupt_Pin2, RISING);
  /*
  attachInterrupt(1, Interrupt_Pin3, HIGH);
  attachInterrupt(2, Interrupt_Pin21, HIGH);
  attachInterrupt(3, Interrupt_Pin20, HIGH);
  attachInterrupt(4, Interrupt_Pin19, HIGH);
  attachInterrupt(5, Interrupt_Pin18, HIGH);
  */


  Serial.begin(9600);

  while (Serial.available() > 0)
    Serial.read();
}

void loop() 
{  
  if (Serial.available() >= 5)
  {
    ReadCommand(); 
    switch (commandNum)
    {
      case 9:
        Serial.print("boi");
      break;

      case 1:
        start_millis = millis();
        GettingData = true;
        LedBlink(4);

      break;

      case 2:
        GettingData = false;
      break;

      
      case 3: // Read a sensor
        sensors[arg2] = new Sensor(arg1, arg2);
      break;
      
    }
    commandNum = 0;
  }

  //delay(10);
}


void ReadCommand()
{
    commandNum = Serial.read();
    arg1 = Serial.read();
    arg2 = Serial.read();
    arg3 = Serial.read();
    arg4 = Serial.read(); 
}


Sensor* ReadSensor()
{
  int type = Serial.read();
  int con = Serial.read();
    

  Sensor *ret = new Sensor(type, con);
  ret->Initiate();
  
  return ret;
}


void Interrupt_Pin2()
{
  digitalWrite(2, LOW);
  Interrupt_General(0);
}
void Interrupt_Pin3()
{
  digitalWrite(3, LOW);
  Interrupt_General(1);
}
void Interrupt_Pin21()
{
  digitalWrite(21, LOW);
  Interrupt_General(5);
}
void Interrupt_Pin20()
{
  digitalWrite(20, LOW);
  Interrupt_General(4);
}
void Interrupt_Pin19()
{
  digitalWrite(19, LOW);
  Interrupt_General(3);
}
void Interrupt_Pin18()
{
   digitalWrite(18, LOW);
  Interrupt_General(2);
}

void Interrupt_General(int num)
{  
  //LedBlink(1);
  
  

  
  if (GettingData) // && digitalRead(sensors[num]->Con->interruptPin) == HIGH)
  {
    if (led_is_on)
      digitalWrite(debug_pin, LOW);
    else
      digitalWrite(debug_pin, HIGH);
    led_is_on = !led_is_on;
    
    switch (sensors[num]->Type)
    {
      case 1:
        Serial.println(String(num) + "," + String((millis() - sensors[num]->value - 10) * 0.017) + "," + String(millis() - start_millis));    
        
        digitalWrite(sensors[num]->Con->digPin1, LOW);
      
        delayMicroseconds(2);
      
        // Sets the trigPin1 on HIGH state for 10 micro seconds
        digitalWrite(sensors[num]->Con->digPin1, HIGH);
        delayMicroseconds(10);
        digitalWrite(sensors[num]->Con->digPin1, LOW);
        sensors[num]->value = millis();
        break;
  
      default:
        break;
    }
  }
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
