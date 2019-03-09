/*
 Name:		O3.ino
 Created:	12/21/2016 11:06:42 AM
 Modified:	03/09/2019 10:00:00 AM
 Author:	Adis Hodzic, Rune Fosse (Modified by Jostein Ring)

Jeg har valgt å benytte meg av koden gitt i løsningsforslaget for Oblig 1 O5 for å løse denne oppgaven.
Min egen kode (selv om den virket) var uoversiktelig og dårlig optimalisert, og ville krevd betydelig mer tid for å "konverteres" til å bruke millis().
*/

unsigned long tid = 0;
int periode = 1000;
int aar = 2019;
int maaned = 12;
int dag = 31;
int Time = 23;
int minutter = 58;
int sekunder = 0;
bool skuddaar = false;

void setup()
{
  Serial.begin(115200);
}

void loop()
{
  //Tilpasning av utskrift
  String utskrift = "";
  utskrift = utskrift + sekunder;
  if (sekunder < 10) utskrift = ":0" + utskrift;
  else utskrift = ":" + utskrift;
  utskrift = minutter + utskrift;
  if (minutter < 10) utskrift = ":0" + utskrift;
  else utskrift = ":" + utskrift;
  utskrift = Time + utskrift;
  if (Time < 10) utskrift = " 0" + utskrift;
  else utskrift = " " + utskrift;
  utskrift = dag + utskrift;
  if (dag < 10) utskrift = "/0" + utskrift;
  else utskrift = "/" + utskrift;
  utskrift = maaned + utskrift;
  if (maaned < 10) utskrift = "/0" + utskrift;
  else utskrift = "/" + utskrift;
  utskrift = aar + utskrift;

  // Timer oppdatering av klokke og skriver info til seriell port
  if (millis() > tid + periode)
  {
    tid = millis();
    Serial.println(utskrift);
    
    //Oppdaterer klokka
    sekunder++;
    if (sekunder == 60)
    {
      sekunder = 0;
      minutter++;
      if (minutter == 60)
      {
        minutter = 0;
        Time++;
        if (Time == 24)
        {
          Time = 0;
          dag++;
          if (maaned == 1 || maaned == 3 || maaned == 5 || maaned == 7 || maaned == 8 || maaned == 10 || maaned == 12)
            //JAN, MAR, MAI, JUL, AUG, OKT, DES
          {
            if (dag == 32)  //32 er en for mye
            {
              dag = 1;
              maaned++;
            }
          }
          else if (maaned == 4 || maaned == 6 || maaned == 9 || maaned == 11)   //APR, JUN, SEP, NOV
          {
            if (dag == 31)  //31 er en for mye
            {
              dag = 1;
              maaned++;
            }
          }
  
          else      //FEB
          {
            if (skuddaar && dag == 30)      // februar har 29 dager I skudd�r
            {
              dag = 1;
              maaned++;
            }
            else if (!skuddaar && dag == 29)  //og 28 dager I ikke-skudd�r
            {
              dag = 1;
              maaned++;
            }
          }
          if (maaned == 13)           // dersom forrige maaned var desember       
          {
            maaned = 1;
            aar++;
  
            // Kode under sjekker om det nyet �ret er skudd�r
            if ((aar % 4) != 0)
            {
              skuddaar = false;
            }
            else if ((aar % 400) == 0)
            {
              skuddaar = true;
            }
            else if ((aar % 100) == 0)
            {
              skuddaar = false;
            }
            else
            {
              skuddaar = true;
            }
  
          }
        } // end if (Hour==24)
      } // end if (Minute==60)
    }//end if (Second==60)
  }
}
