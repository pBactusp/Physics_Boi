#include <TimerOne.h>
#include "Sensors.h"

volatile static unsigned long counter;
int counter_growth = 16000;

bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;


/*Sensor *first;
Sensor *second;*/
int sensor_num;
Sensor *sensors[6];

bool sensor_has_input[6];
float sensor_inputs[6];
int time_stamps[6];


Sensor* ReadSensor()
{
  int type = Serial.read() - '0';
  int con = Serial.read() - '0';
  int sample_rate = Serial.read();
  Sensor *ret = new Sensor(type, con, sample_rate);

  pinMode(ret->Con->digPin1, INPUT);
  pinMode(ret->Con->digPin2, INPUT);
  pinMode(ret->Con->digPin3, INPUT);
  pinMode(ret->Con->interruptPin, INPUT);
  
  pinMode(ret->Con->anPin1, INPUT);
  pinMode(ret->Con->anPin2, INPUT);
      
  return ret;
}


void ReadCommand()
{
    commandNum = Serial.read();
    delay(1);    
    arg1 = Serial.read();
    delay(1);    
    arg2 = Serial.read();
    delay(1);    
    arg3 = Serial.read();
    delay(1);    
    arg4 = Serial.read(); 
}

void SendSensorData(int index)
{
  Serial.print(index);
  Serial.print(sensor_inputs[index]);
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
  switch (sensors[num]->Type)
  {
    case 1:
      sensor_inputs[num] = counter - time_stamps[num];
      sensor_has_input[num] = true;
      break;

    default:
      break;
  }
}


void loop() 
{
  while(Serial.available() != 5){delay(1);}
  
  if (Serial.available() == 5)
  {
    ReadCommand(); 
    
    switch (commandNum)
    {
      case 0:
        Serial.print("boi");
      break;

      case 1:
        GettingData = true;
      break;

      case 2:
        GettingData = false;
      break;
      
      case 3:

        for (int i = 0; i < 6; i++)
          sensors[i] = new Sensor(0, -1, 0);

        sensor_num = arg1 - '0';
        
        for (int i = 0; i < sensor_num; i++)
          sensors[i] = ReadSensor();

        StartMain();
        
      break;
    }
    
  }
  
  delay(10);
}



void setup()
{
  attachInterrupt(0, Interrupt_Pin2, HIGH);
  attachInterrupt(1, Interrupt_Pin3, HIGH);
  attachInterrupt(2, Interrupt_Pin21, HIGH);
  attachInterrupt(3, Interrupt_Pin20, HIGH);
  attachInterrupt(4, Interrupt_Pin19, HIGH);
  attachInterrupt(5, Interrupt_Pin18, HIGH);

  
  Timer1.initialize(16000);
  Timer1.attachInterrupt(Main);
  Serial.begin(9600);
}


void StartMain()
{
  counter = 0;
  GettingData = true;
  for (int i = 0; i < 6; i++)
    sensor_has_input[i] = false;
  Timer1.start();
}


void Main()
{
  for (int i = 0; i < 6; i++)
  {
    sensors[i]->SampleRateCounter++;
    if (sensor_has_input[i] && sensors[i]->SampleRateCounter < sensors[i]->SampleRate)
    {
      SendSensorData(i);
      
      sensors[i]->SampleRateCounter = 1;
      sensor_has_input[i] = false;
      sensor_inputs[i] = 0;

      
      switch (sensors[i]->Type)
      {
        case 1:
          time_stamps[i] = counter;
          
          break;
      }
      
      
      while(Serial.available() == 0){delay(1);}
      commandNum = Serial.read();
      if (commandNum == 1)
      {
        GettingData = false;
        Timer1.stop();
      }
    }
  }

  counter += counter_growth;
}
