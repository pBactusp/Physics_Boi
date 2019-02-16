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

int debug_pin = 12;

/*Sensor *first;
Sensor *second;*/
int sensor_num;
Sensor *sensors[6];

bool sensor_has_input[6];
float sensor_inputs[6];
float time_stamps[6];


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

Sensor* ReadSensor()
{
  //LedBlink(5);
  int type = Serial.read();
  //LedBlink(5);
  int con = Serial.read();
  
  int sample_rate = Serial.read() * 255;
  sample_rate += Serial.read();
  
  //LedBlink(5);

  Sensor *ret = new Sensor(type, con, sample_rate);

  pinMode(ret->Con->digPin1, OUTPUT);
  pinMode(ret->Con->digPin2, INPUT);
  pinMode(ret->Con->digPin3, INPUT);
  pinMode(ret->Con->interruptPin, INPUT);
  
  pinMode(ret->Con->anPin1, INPUT);
  pinMode(ret->Con->anPin2, INPUT);

  
  return ret;
}


void ReadCommand()
{
    commandNum = Serial.read() ;
    //Serial.print(commandNum);
    delay(1);    
    arg1 = Serial.read() ;
    delay(1);    
    arg2 = Serial.read() ;
    delay(1);    
    arg3 = Serial.read() ;
    delay(1);    
    arg4 = Serial.read() ; 
}

void SendSensorData(int index)
{
  Serial.print(index);
  delay(5);
  Serial.print(time_stamps[index]);
  delay(5);
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
      sensor_inputs[num] = (counter - time_stamps[num]) * 0.017f;
      time_stamps[num] = counter;
      sensor_has_input[num] = true;
      break;

    default:
      break;
  }
}


void loop() 
{

  //while(Serial.available() != 5){delay(5);}
  
  if (Serial.available() >= 5)
  {
    //Serial.print("Available");
    ReadCommand();
    //Serial.write(commandNum);
    //Serial.print("\n");
    //Serial.write(arg1);
    //Serial.print("\n");
    //Serial.write(arg2);
    //Serial.print("\n");
    //Serial.write(arg3);
    //Serial.print("\n");
    //Serial.write(arg4);

    switch (commandNum)
    {
      case 9:
        Serial.print("boi");
      break;

      case 1:
        GettingData = true;
      break;

      case 2:
        GettingData = false;
      break;
      
      case 5:

        //Serial.write("banana");

        for (int i = 0; i < 6; i++)
          sensors[i] = new Sensor(0, -1, 0);

        sensor_num = arg1;
        
        //LedBlink(5);
        for (int i = 0; i < sensor_num; i++)
        {
          //LedBlink(10);
          sensors[i] = ReadSensor();
          
        }

        if (sensors[0]->Con->digPin1 == 4)
          LedBlink(5);


        StartMain();
        
      break;
    }
    
  }
  
  delay(10);
}



void setup()
{
  pinMode(debug_pin, OUTPUT);
  Serial.begin(9600);
}


void StartMain()
{
  attachInterrupt(0, Interrupt_Pin2, HIGH);
  attachInterrupt(1, Interrupt_Pin3, HIGH);
  attachInterrupt(2, Interrupt_Pin21, HIGH);
  attachInterrupt(3, Interrupt_Pin20, HIGH);
  attachInterrupt(4, Interrupt_Pin19, HIGH);
  attachInterrupt(5, Interrupt_Pin18, HIGH);

  
  Timer1.initialize(16000);
  Timer1.attachInterrupt(Main);
  
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
          digitalWrite(sensors[i]->Con->digPin1, HIGH);
          delayMicroseconds(10);
          digitalWrite(sensors[i]->Con->digPin1, LOW);
          time_stamps[i] = counter;
          
          break;
      }
      

      if (Serial.available() > 0)
      {
        commandNum = Serial.read();
        if (commandNum == 1)
        {
          GettingData = false;
          Timer1.stop();
        }
      }
      
      
    }
  }

  counter += counter_growth;
}
