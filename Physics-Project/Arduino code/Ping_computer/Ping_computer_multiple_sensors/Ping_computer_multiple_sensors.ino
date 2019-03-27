#include <TimerOne.h>
#include "Sensors.h"

bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;

int sensor_num;
Sensor *sensors[6];

const int debug_pin = 12;

int start_millis;

void setup()
{
  /*pinMode(trigPin1, OUTPUT);
  pinMode(echoPin1, INPUT);

  pinMode(trigPin2, OUTPUT);
  pinMode(echoPin2, INPUT);*/

  pinMode(debug_pin, OUTPUT);

  attachInterrupt(0, Interrupt_Pin2, HIGH);
  attachInterrupt(1, Interrupt_Pin3, HIGH);
  attachInterrupt(2, Interrupt_Pin21, HIGH);
  attachInterrupt(3, Interrupt_Pin20, HIGH);
  attachInterrupt(4, Interrupt_Pin19, HIGH);
  attachInterrupt(5, Interrupt_Pin18, HIGH);
  
  Serial.begin(9600);
}

void loop() 
{  
  if (Serial.available() == 5)
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
        //SendData();
      break;

      case 2:
        GettingData = false;
        
      break;

      
      case 3: // Read a sensor
        sensors[arg2] = new Sensor(arg1, arg2);
        sensors[arg2]->Initiate();
      break;
      
    }
    
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

/*void SendData()
{
  float duration1, duration2;
  
  for (int i = 2; i > 0 && GettingData; i--)
  {
    digitalWrite(trigPin1, LOW);
    digitalWrite(echoPin1, LOW);

    digitalWrite(trigPin2, LOW);
    digitalWrite(echoPin2, LOW);
    
    delayMicroseconds(2);
    
    // Sets the trigPin1 on HIGH state for 10 micro seconds
    digitalWrite(trigPin1, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin1, LOW);
    duration1 = pulseIn(echoPin1, HIGH);


    digitalWrite(trigPin2, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin2, LOW);
    duration2 = pulseIn(echoPin2, HIGH);
  }

  start_millis = millis();
  while (GettingData)
  {
    digitalWrite(trigPin1, LOW);
    digitalWrite(echoPin1, LOW);

    digitalWrite(trigPin2, LOW);
    digitalWrite(echoPin2, LOW);
    
    delayMicroseconds(2);
    
    // Sets the trigPin1 on HIGH state for 10 micro seconds
    digitalWrite(trigPin1, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin1, LOW);
    duration1 = pulseIn(echoPin1, HIGH);


    digitalWrite(trigPin2, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin2, LOW);
    duration2 = pulseIn(echoPin2, HIGH);
    
    Serial.println(String(0) + "," + String(duration1*0.017) + "," + String(millis() - start_millis));    
    Serial.println(String(2) + "," + String(duration2*0.017) + "," + String(millis() - start_millis));    

    if (Serial.available() > 0)
    {
      commandNum = Serial.read();
      if (commandNum == 1)
        GettingData = false;
    }
    delay(10);
  }
}*/

Sensor* ReadSensor()
{
  int type = Serial.read();
  int con = Serial.read();
  
  //int sample_rate = Serial.read() * 255;
  //sample_rate += Serial.read();
  

  Sensor *ret = new Sensor(type, con); //, sample_rate);
  ret->Initiate();
  
  return ret;
}


void Interrupt_Pin2()
{
  Interrupt_General(0);
}
void Interrupt_Pin3()
{
  Interrupt_General(1);
}
void Interrupt_Pin21()
{
  Interrupt_General(5);
}
void Interrupt_Pin20()
{
  Interrupt_General(4);
}
void Interrupt_Pin19()
{
  Interrupt_General(3);
}
void Interrupt_Pin18()
{
  Interrupt_General(2);
}

void Interrupt_General(int num)
{
  if (GettingData)
    switch (sensors[num]->Type)
    {
      case 1:
        Serial.println(String(num * 2) + "," + String((millis() - sensors[num]->value - 10) * 0.017) + "," + String(millis() - start_millis));    
        
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
