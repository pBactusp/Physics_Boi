
void setup()
{
  
  Serial.begin(1000000);
}

void loop()
{
  
  Serial.println(analogRead(A4));
  
  delay(17);
}
