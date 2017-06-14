#include <Servo.h>


Servo servoLeft;
Servo servoRight;

int needIR = 200;

int IR_LedPin = 3;
int IR_InputPin = A0;

bool isStarted = false;

void setup()
{
  Serial.begin(9600);
  servoLeft.attach(10);
  servoLeft.write(150);
  
  servoRight.attach(11);
  servoRight.write(30);
 
  pinMode(IR_LedPin, OUTPUT);
  digitalWrite(IR_LedPin, HIGH);
  
  pinMode (IR_InputPin, INPUT);
}

void loop()
{
  if (Serial.available() > 0 && !isStarted)
     if (Serial.parseInt() == 47)
        isStarted = true;
  
  //Serial.println(analogRead(IR_InputPin));
  
  // Пришла фигура
  if ((analogRead(IR_InputPin) > needIR) && isStarted)
  {
    Serial.write(7);
    bool waitAnswer = true;
    while(waitAnswer)
    {
      if (Serial.available() > 0)
      {
        waitAnswer = false;
        int command = Serial.parseInt();
        switch(command)
        {
         case 1:
         {
          servoLeft.write(70);
          delay(500);
          servoLeft.write(150);
         }
         break;
         
         case 2:
         {
          servoRight.write(110);
          delay(500);
          servoRight.write(30);
         }
         break;

         case 0:
         default:
         break;
        }
        
        Serial.write(8); // done
      }
      delay(100);
    }
    
    do
    {
      delay(300);
    } while(analogRead(IR_InputPin) > needIR);    
  }
  delay(50);
}
