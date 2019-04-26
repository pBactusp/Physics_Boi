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
    
    Connection(int connection_num)
    {
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
    float value;
    //int SampleRate; // Sample every x ticks
    //int SampleRateCounter;

    void Initiate()
    {
      switch (Type)
      case 1:
        pinMode(Con->digPin1, OUTPUT);
        pinMode(Con->interruptPin, INPUT_PULLUP);
    }
    
    Sensor(int type, int con) //, int sample_rate)
    {
        //SampleRate = sample_rate;
        //SampleRateCounter = 1;
        Con = new Connection(con);
        Type = type;

        Initiate();
        
        switch(Type)
        {
          case 0:
          
            break;
          
          case 1:
            
            digitalWrite(Con->digPin1, LOW);
            digitalWrite(Con->interruptPin, LOW);
          
            delayMicroseconds(2);
          
            digitalWrite(Con->digPin1, HIGH);
            value = millis();
            delayMicroseconds(10);
            digitalWrite(Con->digPin1, LOW);
            break;
          
          case 2:
          
            break;   
        }
      
      }
	private:
	
};
