
bool GettingData = false;
byte commandNum;
byte arg1;
byte arg2;
byte arg3;
byte arg4;

const int trigPin1 = 4;
const int echoPin1 = 2;

const int trigPin2 = 8;
const int echoPin2 = 7;

int start_millis;

void setup()
{
  pinMode(trigPin1, OUTPUT);
  pinMode(echoPin1, INPUT);

  pinMode(trigPin2, OUTPUT);
  pinMode(echoPin2, INPUT);
  
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
      case 9:
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
    /*if (digitalRead(InputPin) == HIGH)
    {
      //Serial.print(50, DEC);
      Serial.print(2.031f, 5);
      digitalWrite(LedPin, HIGH);
    }
    else
    {
      Serial.print(0);
      digitalWrite(LedPin, LOW);
    }*/

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
}
