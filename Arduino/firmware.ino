#include <Servo.h>

Servo servoLeft;
Servo servoRight;

int degServoLeft = 130;
int degServoRight = 50;

int needIR = 200;

int IR_LedPin = 3;
int IR_InputPin = A0;

bool isStarted = false;

void setup()
{
  Serial.begin(9600);
  servoLeft.attach(10);
  servoLeft.write(degServoLeft);
  
  servoRight.attach(11);
  servoRight.write(degServoRight);
 
  pinMode(IR_LedPin, OUTPUT);
  digitalWrite(IR_LedPin, HIGH);
  
  pinMode (IR_InputPin, INPUT);
}

void loop()
{

  //Serial.println((analogRead(IR_InputPin))); // отладка
  
  if (Serial.available() > 0 && !isStarted)
     if (Serial.parseInt() == 47)
        isStarted = true;
  
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
          servoLeft.write(80);
          delay(500);
          servoLeft.write(degServoLeft);
         }
         break;
         
         case 2:
         {
          servoRight.write(100);
          delay(500);
          servoRight.write(degServoRight);
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
      delay(400);
    } while(analogRead(IR_InputPin) > needIR);    
  }
  delay(50);
}
