
bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;

const int trigPin = 4;
const int echoPin = 2;

void setup()
{
  pinMode(A0, INPUT);
  
  Serial.begin(9600);
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
        SendData();
      break;

      case 2:
        GettingData = false;
      break;
    }
    
  }
  
  delay(10);
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

void SendData()
{
  float ret;
  
  for (int i = 2; i > 0 && GettingData; i--)
  {
    ret = analogRead(A0);
  }
  
  while (GettingData)
  {
    ret = 5 * analogRead(A0) / 1024;

    
    Serial.print(ret);

    
    while(Serial.available() == 0){delay(1);}
    commandNum = Serial.read();

    if (commandNum == 1)
    {
      GettingData = false;
    }
    delay(10);
  }
}
