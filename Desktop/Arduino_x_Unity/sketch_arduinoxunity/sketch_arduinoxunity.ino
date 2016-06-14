/*
 * Calling out all the sensors and their locations on the Arduino Pro Mini.
 * SW, X and Y pin are are part of the joystick using a mixture and digital and analog power
 * All the buttons are digital sensors and are using digital power
 */  
const int button1 = 5;
const int button2 = 6;

//declaring the variable names to distinguish all the buttons in code
int buttonOne;
int buttonTwo;

void setup() {
  //declaring all variables as inactive/inputs
  pinMode(button1, INPUT);
  pinMode(button2, INPUT);
 
  Serial.begin(9600);
}

void loop() {
  buttonOne = digitalRead(button1);
  buttonTwo = digitalRead(button2);
  
  //Using booleans to call any push or button-presses as a number for Unity to read within C-Sharp
  if(buttonOne == LOW) {
    Serial.write(5);
    Serial.println("button1pressed");      
  }
   if(buttonTwo == LOW) {
    Serial.write(6);
    Serial.println("button22");      
  }
  Serial.flush();
  delay(20);

}

