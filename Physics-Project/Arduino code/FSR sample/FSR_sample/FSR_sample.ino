
void setup()
{
  
  Serial.begin(1000000);
}

void loop()
{
  
  Serial.println(analogRead(A0));
  
  delay(1000);
}
