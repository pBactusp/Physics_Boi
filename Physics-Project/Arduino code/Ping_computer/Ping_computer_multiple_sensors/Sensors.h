#import <Arduino.h>

class Connection
{
  public:
    int digPin1;
    int digPin2;
    int digPin3;
    int interruptPin;
    
    int anPin1;
    int anPin2;

    int Num;

    
    Connection(int connection_num)
    {
      Num = connection_num;
      switch (connection_num)
      {
      // Interrupt Pins: 2, 3, 18, 19, 20, 21
        case 0:
        digPin1 = 4;
        digPin2 = 5;
        digPin3 = 6;
        interruptPin = 2;
        
        anPin1 = A0;
        anPin2 = A1;
        break;
        
        case 1:
        digPin1 = 7;
        digPin2 = 8;
        digPin3 = 9;
        interruptPin = 3;
        
        anPin1 = A2;
        anPin2 = A3;
        break;
        
        case 2:
        digPin1 = 10;
        digPin2 = 11;
        digPin3 = 12;
        interruptPin = 21;
        
        anPin1 = A4;
        anPin2 = A5;
        break;
        
        case 3:
        digPin1 = 13;
        digPin2 = 14;
        digPin3 = 15;
        interruptPin = 20;
        
        anPin1 = A6;
        anPin2 = A7;
        break;
        
        case 4:
        digPin1 = 23;
        digPin2 = 24;
        digPin3 = 25;
        interruptPin = 19;
        
        anPin1 = A8;
        anPin2 = A9;
        break;
        
        case 5:
        digPin1 = 26;
        digPin2 = 27;
        digPin3 = 28;
        interruptPin = 18;
        
        anPin1 = A10;
        anPin2 = A11;
        break;
      }

    }
  private:
  
};

class Sensor
{
	public:
		int Type;
		Connection *Con;
    float Value;
    bool Interrupted;
    unsigned long LastSampleTime;
    float SampleRate;
    unsigned long SamplePeriod;

        
    void AttachPins()
    {
      switch (Type)
      {
      case 1:
        pinMode(Con->digPin1, OUTPUT);
        pinMode(Con->interruptPin, INPUT);
        break;

      case 2:
      case 3:
      case 4:
        pinMode(Con->anPin1, INPUT);
        break;
        
      default:
      
        break;
      }
    }
    
    Sensor(int type, int con) //, int sample_rate)
    {
        //SampleRate = sample_rate;
        //SampleRateCounter = 1;
        Con = new Connection(con);
        Type = type;
        Interrupted = true;

        if (Type != 0)
          AttachPins();
      }
	
    void Set(int type, float sampleRate)
    {
      Type = type;
      Interrupted = true;
      SampleRate = sampleRate;

      SamplePeriod = (unsigned long)(1000.0 / SampleRate);

      if (Type != 0)
          AttachPins();
    }

    
    void Activate()
    {
      switch(Type)
      {
        case 0:
        
          break;
        
        case 1:
          digitalWrite(Con->digPin1, HIGH);
          delayMicroseconds(10);
          digitalWrite(Con->digPin1, LOW);
          Interrupted = false;
          LastSampleTime = micros();
          break;

        case 2:
        case 3:
        case 4:
          Value = analogRead(Con->anPin1);
          LastSampleTime = micros();
          break;
        
        default:
          break;   
      }
    }
	
	private:
	
};
