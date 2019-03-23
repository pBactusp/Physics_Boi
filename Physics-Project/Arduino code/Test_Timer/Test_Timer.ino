#include <TimerOne.h>

volatile static unsigned long counter;
int counter_growth = 1;
int counter_max= 4;

bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;


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


void Interrupt_Pin2()
{
}


void loop() 
{

  //while(Serial.available() != 5){delay(5);}
  
  if (Serial.available() > 0)
  {
    commandNum = Serial.read();
    Serial.write(commandNum);
    
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
      
      case 49:
        GettingData = true;
      break;
      
    }
    
  }

  if (GettingData)
  {
    GettingData = false;
    StartMain();
  }
  
  delay(10);
}



void setup()
{
  noInterrupts();
  Serial.begin(9600);
  interrupts();
}


void StartMain()
{
  attachInterrupt(0, Interrupt_Pin2, HIGH);

  
  Timer1.initialize(16000);
  Timer1.attachInterrupt(Main);
  
  counter = 0;
  GettingData = true;
  
  Timer1.start();
}


void Main()
{
  counter++;
  Serial.print(counter);

  if (counter >= counter_max)
  {
    Serial.print("The timer done!");
    Timer1.stop();
  }
  
}
