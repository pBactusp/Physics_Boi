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
        
        anPin1 = 0;
        anPin2 = 1;
        break;
        
        case 1:
        digPin1 = 7;
        digPin2 = 8;
        digPin3 = 9;
        interruptPin = 3;
        
        anPin1 = 2;
        anPin2 = 3;
        break;
        
        case 2:
        digPin1 = 10;
        digPin2 = 11;
        digPin3 = 12;
        interruptPin = 18;
        
        anPin1 = 4;
        anPin2 = 5;
        break;
        
        case 3:
        digPin1 = 13;
        digPin2 = 14;
        digPin3 = 15;
        interruptPin = 19;
        
        anPin1 = 6;
        anPin2 = 7;
        break;
        
        case 4:
        digPin1 = 23;
        digPin2 = 24;
        digPin3 = 25;
        interruptPin = 20;
        
        anPin1 = 8;
        anPin2 = 9;
        break;
        
        case 5:
        digPin1 = 26;
        digPin2 = 27;
        digPin3 = 28;
        interruptPin = 21;
        
        anPin1 = 10;
        anPin2 = 11;
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
    int SampleRate; // Sample every x ticks
    int SampleRateCounter;
    
    //Sensor::Sensor(int type, Connection con);
    Sensor(int type, int con, int sample_rate)
    {
        SampleRate = sample_rate;
        SampleRateCounter = 0;
        Con = new Connection(con);
        Type = type;
        
        switch(Type)
        {
          case 0:
          
            break;
          
          case 1:
            Con->digPin1 = 1;
            Con->interruptPin = 2;
            break;
          
          case 2:
          
            break;   
        }
      
      }
	private:
	
};
