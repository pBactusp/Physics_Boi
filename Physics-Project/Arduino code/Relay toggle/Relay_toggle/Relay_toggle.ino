int toggle[2] {50, 51};

int arg[4];

void setup()
{
  for (int i = 0; i < sizeof(toggle); i++)
    pinMode(toggle[i], OUTPUT);
  

  Serial.begin(9600);
}

void loop()
{
  if (Serial.available() > 0)
  {
    ReadCommand(); 
  }

}


void ReadCommand()
{
    String command = Serial.readString();
    
    if (command.substring(0, 6) == "toggle")
    {
      SplitString(command.substring(7));
      if (arg[1] == 0)
        digitalWrite(toggle[arg[0]], LOW);
      else
        digitalWrite(toggle[arg[0]], HIGH); 
    }

    Serial.println("ok");
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
