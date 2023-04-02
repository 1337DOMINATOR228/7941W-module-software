/*
  Description: Read the card number.
  Date: 2018/09/19
  Author: Alan
  Contact: You can contact the author via github, the username is "AlanBling".
*/

int i = 0;

void setup()
{
  Serial.begin(9600); //串口0，就是PWM区域里的Pin0和Pin1脚
  Serial3.begin(9600); //串口1，即Pin15及Pin14
}
void loop()
{

  while (Serial3.available() > 0) {


    Serial.print("0x");
    Serial.print(Serial3.read(), HEX);
    Serial.print(", ");
    i++;
  }
  if (i == 10) {
    Serial.println("");
    i  = 0;
  }


}
