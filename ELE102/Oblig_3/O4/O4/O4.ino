/*
 Name:		O4.ino
 Created:	3/9/2019 11:26:07 AM
 Author:	Jostein Ring
*/

//Konstanter og variabler for LED og knapper
const int redbtn = 4;
const int greenbtn = 2;
const int redLED = 8;
const int greenLED = 7;

int redstate;
int redprevious = 0;
int rednow = 1;
int greenstate;
int greenprevious = 0;
int greennow = 1;

//variabler for potensiometer
int analogPin = A0;
int val = 0;

//Variabler for tidsutskrift
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
	pinMode(redbtn, INPUT_PULLUP);
	pinMode(greenbtn, INPUT_PULLUP);
	pinMode(redLED, OUTPUT);
	pinMode(greenLED, OUTPUT);
}

void loop()
{
	//Knapper og LED
	redstate = digitalRead(redbtn);
	greenstate = digitalRead(greenbtn);

	if (redstate == 0 && redprevious == 1)
	{
		if (rednow == 1) rednow = 0;
		else rednow = 1;
	}
	if (greenstate == 1 && greenprevious == 0)
	{
		if (greennow == 1) greennow = 0;
		else greennow = 1;
	}
	digitalWrite(redLED, rednow);
	redprevious = redstate;
	digitalWrite(greenLED, greennow);
	greenprevious = greenstate;

	//Potensiometer
	val = analogRead(analogPin);

	//Tilpasning av utskrift
	String utskrift = "#";

	utskrift = rednow + utskrift;
	utskrift = "" + utskrift;
	utskrift = greennow + utskrift;
	utskrift = "D" + utskrift;

	utskrift = val + utskrift;
	if (val < 10)
	{
		utskrift = "000" + utskrift;
		utskrift = "C" + utskrift;
	}
	else if (val < 100)
	{
		utskrift = "00" + utskrift;
		utskrift = "C" + utskrift;
	}
	else if (val < 1000)
	{
		utskrift = "0" + utskrift;
		utskrift = "C" + utskrift;
	}
	else utskrift = "C" + utskrift;

	utskrift = sekunder + utskrift;
	if (sekunder < 10) utskrift = ":0" + utskrift;
	else utskrift = ":" + utskrift;

	utskrift = minutter + utskrift;
	if (minutter < 10) utskrift = ":0" + utskrift;
	else utskrift = ":" + utskrift;
	
	utskrift = Time + utskrift;
	if (Time < 10) utskrift = "B0" + utskrift;
	else utskrift = "B" + utskrift;
	
	utskrift = aar + utskrift;
	utskrift = "/" + utskrift;
	
	utskrift = maaned + utskrift;
	if (maaned < 10) utskrift = "/0" + utskrift;
	else utskrift = "/" + utskrift;
	
	utskrift = dag + utskrift;
	if (dag < 10) utskrift = "$A0" + utskrift;
	else utskrift = "$A" + utskrift;

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