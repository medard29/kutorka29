
#include <Wire.h> 
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27,20,4);
int hrac1 = 120;
int hrac2 = 120;
int cas1;
int cas2;
bool hraje1 = true;

void setup()
{
  lcd.init();                     
  lcd.backlight();
}


void loop()
{
  if(hrac1==0 || hrac2==0)
  {
    if(hraje1)
    {
      delay(1000);
      cas1++;
      hrac1--;

    }
    else
    {
      delay(1000);
      cas2++;
      hrac2--;
    }
    }
  else
  {
    if(hrac1==0)
    {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.setCursor("Vyhral");
      lcd.setCursor(0, 1);
      lcd.print("hrac 2");
    }
    else
    {
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.setCursor("Vyhral");
      lcd.setCursor(0, 1);
      lcd.print("hrac 1");
    }
  }

}

void Zobraz()
{
  int minutes1 = cas1 / 60;
  int seconds1 = cas1 % 60;
  int minutes2 = cas2 / 60;
  int seconds2 = cas2 % 60;

  if(seconds1>=10)
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.setCursor("šachové hodiny");
    lcd.setCursor(0, 1);
    lcd.print(minutes1);
    lcd.print(":");
    lcd.print(seconds1);
    lcd.print("/");
    lcd.print(minutes2);
    lcd.print(":");
    lcd.print(seconds2);


    
  }
  else
  {
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.setCursor("šachové hodiny");
    lcd.setCursor(0, 1);
    lcd.print(minutes1);
    lcd.print(":");
    lcd.print(0);
    lcd.print(seconds1);
    lcd.print("/");
    lcd.print(minutes2);
    
    lcd.print(":");
    lcd.print(seconds2);
  }

}
