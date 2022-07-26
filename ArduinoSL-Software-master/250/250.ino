#include <SimpleDHT.h>
#include <Adafruit_BMP280.h>
#include <Wire.h>  
#include <OneWire.h>
#include <DallasTemperature.h>

#define ONE_WIRE_BUS D7
OneWire oneWire(ONE_WIRE_BUS);
DallasTemperature sensors(&oneWire);
#define BMP280_I2C_ADDRESS  0x76
Adafruit_BMP280  bmp280;

const double pi = 3.14;
double diameter = 0; //Diametrul cilindrului
double Length = 0; // Lungime paralelipiped
double Width = 0; // Latime paralelipied
double BaseArea = 0; // Aria bazei bazinului

const int pinSenzor = D4; // Declaram pin-ul D4 pentru DHT11
const int echoPIN = D5; // Declaram pin-ul ECHO de la senzorul ultrasunet ca D5
const int trigPIN = D3; // Declaram pin-ul trig de la senzorul ultrasunet ca D3
const int sensorPin = A0; // Senzorul pentru umiditatea apei
const int pompa = D6; // Declaram pompa pe D6
const int pinBuzzer = D0; // Setam buzzer-ul pe D0

String readString;
String caseData;
String switchCase;
int stringLength;

double WaterDepth, WaterRefill;
long timp; // Declaram timpul si distanta care ne vor ajuta sa calculam distanta masurata cu ajutorul ultrasunetelor
double distanta; // Variabila in care vom tine distanta calculata cu ajutorul undelor de senzorul cu ultrasunet HC-SR04+
double vectorValori[4]; // Cele 5 valori pentru filtrul median
int sensorValue; // Variabila in care vom tine datele citite de senzorul de umiditate
bool pompaIsRunning = 0; // Setam ca la inceput pompa nu este pornita
bool tempTooHigh =  0;

double apa, pressure;

bool engage = 0; // flag pentru ciclul de udare

double TankDepth = 0; // Primeste data prin Serial de la SmartLauncher si reprezinta distanta, in centimetri, pana la fundul bazinului


double AvailableWater; // Data trimisa catre SmartLauncher prin Serial
double InitDistance ;
double InitVolume ;
double WaterToSend ; // Primeste data prin Serial de la SmartLauncher
double WaterOut ; // Data trimisa catre SmartLauncher prin Serial
double VolumeWaterLeft ; // Data trimisa catre SmartLauncher prin Serial
double ddistanta;

double MinDistance=0;
double MaxDistance=0; // TankDepth - 3 cm pentru a nu ramane pompa fara apa
double TankCapacity=0;
double MaxWater = 0;
double AAvailableWater;

short HumidityValue;

double WaterRefillLevel = 0;
bool WorkMode = false; // Pompa porneste pe modul MANUAL (FALSE)
bool TankType = false; // 0 pentru cylinder si 1 pentru paralelipipedic

SimpleDHT11 dht11; // Declaram senzorul DHT11
void TstError()
{
  TankDepth = 20;
  diameter = 6;
  TankType = false;
  WorkMode = true;
}
void swapFunct(double &a, double &b) // Functie creata pentru a schimba valorile a doua variabile de tip DOUBLE. Folosita pentru sortarea vectorului.
{
  double x=a;
  a=b;
  b=x;  
}

void Anulare()
{
  digitalWrite(pinBuzzer,LOW);
  delay(100);
  digitalWrite(pinBuzzer,HIGH);
  engage = 0;
  digitalWrite(pompa,HIGH);
}

  
void StartButton ()
{
   if (engage == 0)
  {
    engage = 1; // previne reinitializarea daca se reapasa butonul de start
    digitalWrite(pompa,LOW); // pornim pompa
    // mesaj ca a pornit irigarea conform datelor introduse bla-bla-bla
   }
}

void Alarm ()
  {
      digitalWrite(pinBuzzer,LOW);
      delay(100);
      digitalWrite(pinBuzzer,HIGH);
      delay(20);
      digitalWrite(pinBuzzer,LOW);
      delay(100);
      digitalWrite(pinBuzzer,HIGH);
      delay(20);
      digitalWrite(pinBuzzer,LOW);
      delay(100);
      digitalWrite(pinBuzzer,HIGH);
  }

void setup() 
{
  Serial.begin(115200);
  pinMode(trigPIN, OUTPUT);  // Declaram trig ca OUTPUT
  pinMode(echoPIN, INPUT); // Declaram echo ca OUTPUT 
  pinMode(pompa,OUTPUT);   // Declaram pompa ca OUTPUT
  digitalWrite(pompa, HIGH); // Intrucat releul este de tip actionare cu LOW, ne asiguram ca pompa nu are curent inainte de pornirea loop-ului -- SCHIMBAT HIGH RELEU
  pinMode(sensorPin,INPUT); // Declaram senzorul DHT11 ca INPUT 
  pinMode(pinBuzzer,OUTPUT); // Declaram buzzer-ul ca OUTPUT
  digitalWrite(pinBuzzer,HIGH); // Setam buzzer-ul (este pe LOW ca si releul) deoarece in primul ciclu nu dorim sa fie pornit decat daca conditia necesara este intalnita (temperatura din solar sa depaseasca valoarea maxima setata de utilizator)
  Wire.begin(D2, D1);
  bmp280.begin(0x76);
  sensors.begin();
}

void loop() 
{
  if(Serial.available())  
  {
    readString = Serial.readString();
    if(readString.length() > 0)
    {
      stringLength=0;
      switchCase = "";
      caseData = "";
      stringLength = readString.length();
      switchCase = readString.substring(0,1);
      caseData = readString.substring(1, stringLength);
      switch(switchCase.c_str()[0])
      {
        case 'T' : TankDepth = caseData.toDouble();break;
        case 'X' : WaterToSend = caseData.toDouble(); StartButton();  break;
        case 'A' : Anulare(); break;
        case 'Z' : WorkMode = false; break; // Setam pompa pe MANUAL
        case 'C' : WorkMode = true; break; // Setam pompa pe AUTO
        case 'J' : TankType = false; break; // Tank = cylinder
        case 'K' : TankType = true; break; // Tank = paralelipipedic
        case 'D' : diameter = caseData.toDouble(); break; 
        case 'L' : Length = caseData.toDouble(); break;
        case 'W' : Width = caseData.toDouble(); break;
      }
    readString = "";
    }
  }
  bool WWorkMode = WorkMode;
  double WWaterToSend = WaterToSend;
  double TTankDepth = TankDepth;
  double ddiameter = diameter;
  double LLength = Length;
  double WWidth = Width;
  bool TTankType = TankType;
  
  for(int i=0;i<=4;++i)
  {
    digitalWrite(trigPIN,LOW);// Pregatim trig pentru citire
    delayMicroseconds(2);
    digitalWrite(trigPIN,HIGH); // Deschidem transmitatorul de pe senzorul de ultrasunete pentru 10 ms apoi il inchidem
    delayMicroseconds(10);
    digitalWrite(trigPIN, LOW);// Pregatim trig pentru citire
    timp = pulseIn(echoPIN, HIGH); // Citeste PIN-ul echo care este receptorul de pe placuta. Acesta contine in ms timpul care le ia undelor sa ajung la receptor.
    if(timp == 0)
    {
      pinMode(echoPIN, OUTPUT);
      digitalWrite(echoPIN, LOW);
      delayMicroseconds(200);
      pinMode(echoPIN, INPUT);
    }
    distanta = timp*0.034/2; // Calculam distanta folosindu-ne de timp si de viteza. Desi distanta = viteza * timp, viteza este cunoscuta. Folosind ultrasunete stim ca viteza sunetului este 0,034 astfel putem calcula distanta
    vectorValori[i] = distanta; // Punem distanta calculata in vectorul de valori
    delay(50);
  }

   // Sortam vectorul cu cele 5 valori citite de senzorul cu ultrasunet HC-SR04+
   
   for(int i=1;i<=4;++i)
    if(vectorValori[i-1] > vectorValori[i])
          swapFunct(vectorValori[i-1], vectorValori[i]);
        
   //Sfarsit sortare vector
   
   // Media Aritmetica a celor 3 valori, eliminand valoarea minima si cea maxima

   
    if(TTankType == false)
    {
      BaseArea = (pi * ddiameter * ddiameter) / 4;
    }
    else
    {
      BaseArea = LLength * WWidth;
    }
   
   MaxDistance = TTankDepth-3;
   TankCapacity = (MaxDistance-MinDistance)*BaseArea; // valoare in cm3, respectiv mililitri
   
   distanta = 0; // Resetam valoarea variabilei distanta
   for(int i=1;i<=3;++i) // For incepe de la 1 si merge pana la 3 inclusiv. Pasurile 0 si 4 nu sunt luate in considerare deoarece acestea reprezinta valoarea minima si cea maxima.
     distanta = distanta + vectorValori[i]; 
   distanta = distanta / 3; // Media aritmetica (centimetri)
    double ddistanta = distanta;
    
   // Sfarsit Medie Aritmetica
   
  // In permanenta ne asiguram ca apa din bazin nu coboara sub nivelul critic
   if(pompaIsRunning == 1)
   {
      if(ddistanta >= MaxDistance)
      {
        digitalWrite(pompa,HIGH);  // Oprim pompa pentru a nu provoca defectiuni la pompa. Nu dorim sa ruleze fara apa sau cu un nivel al apei foarte mic
        pompaIsRunning = 0; // Tinem cont ca am oprit pompa
      }
   }
    
       
      AvailableWater = (MaxDistance - ddistanta)*BaseArea; // Calculam ,in mililitri, volumul de apa disponibil in bazinul cu apa
      AAvailableWater = AvailableWater;
     if(engage == 0)
     {
      InitVolume = AAvailableWater;
     
      InitDistance = ddistanta;
     }      
   if(InitDistance < ddistanta)
   {
      WaterOut = (ddistanta - InitDistance)*BaseArea; // Calculam volumul de apa administrat
      VolumeWaterLeft = (InitVolume - WaterOut);
   }
   else
   {
      WaterOut = 0; // Irigarea nu a inceput
      VolumeWaterLeft = AAvailableWater;
   }

 
 if (WaterOut>=WWaterToSend)
 {
    digitalWrite(pompa,HIGH); // oprim pompa
    pompaIsRunning = 0; // Retinem ca pompa este oprita
    //mesaj ca s-a administrat cantitatea dorita si optiune pentru a relua sau a iesi din aplicatie
    engage = 0;
 }
 sensorValue= analogRead(sensorPin); // Citim senzorul de umiditate
 if(WWorkMode == true) // Modul automat
 {
   if(sensorValue <= 900 && sensorValue >= 500 && WWorkMode == true)
    { 
      //Serial.println("Pompa functioneaza! Umiditate la nivel intermediar");
    }
  
   if(sensorValue > 900 && WWorkMode == true && ddistanta < MaxDistance)
    {
     // Serial.println("Nivel critic umiditate. Se porneste pompa");
      digitalWrite(pompa,LOW); // Pornim pompa
      pompaIsRunning = 1;
    }
   
    if(sensorValue < 500 && WWorkMode == true)
    {
      //Serial.println("Nivel maxim umiditate. Se opreste pompa");
        digitalWrite(pompa,HIGH); // Oprim pompa
        pompaIsRunning = 0;  
    }
 
     if(digitalRead(D6) == LOW) // Verificam daca pompa este pornita
      {
          if (sensorValue > 900) // In cazul in care pompa este pornita si nivelul de umiditate este critic sa porneasca alarma
          { 
            Alarm();
          }
      }
  }

 // Temperatura si Umiditate
  
  byte temperatura = 0, umiditate = 0; // Declaram variabilele pentru temperatura si umiditate
  dht11.read(pinSenzor, &temperatura, &umiditate, NULL); // Citirea temperaturii si a umiditatii cu senzorul DHT11
 // Sfarsit Temperatura si Umiditate

   if(digitalRead(pompa) == LOW) // Verificam daca pompa este pornita sau oprita, rezultatul este pus in variabila pompaIsRunning
      pompaIsRunning = 1; // daca pompa este pornita
   else
      pompaIsRunning = 0; // daca pompa este oprita

  WaterDepth = TTankDepth - ddistanta; 
  WaterRefill = TankCapacity - AAvailableWater;
  
  if(sensorValue > 500 && sensorValue < 1000)
    HumidityValue = map(sensorValue, 500, 1020, 100, 0); // Transformam in procente nivelul umiditatii, urmand sa fie transmis prin serial catre SmartLauncher
  else if(sensorValue <= 500)
    HumidityValue = 100;
  else
    HumidityValue = 0;
    
  // Citirea si obtinerea datelor de la senzorul BMP280(Presiunea atmosferica)si sonda DS18B20 (Temperatura apei din bazin)
  sensors.requestTemperatures(); // Citim sonda
  apa = sensors.getTempCByIndex(0); // Stocam valoarea temperaturii in celsius
  pressure = bmp280.readPressure(); // Citim BMP280
  pressure *= 0.00750062; // Transformam din Pa (1 Pascal) in MMHG (1 milimetru coloana de mercur)
  
    
 // Trimiterea datelor catre SmartLauncher
  Serial.print((String) temperatura + "a" + umiditate + "b" + ddistanta + "c" + AAvailableWater + "d" + WaterRefill+ "e" + WaterDepth + "f" + pompaIsRunning + "g" + TankCapacity + "h" + WorkMode + "i" + HumidityValue + "j" + apa + "k" + pressure + "l" + "\n"); // Printam in Serial detaliile ce vor fi preluate de catre SmartLauncher pentru a fi afisate

  delay(100); // Asteptam 1 secunda pana la urmatorul ciclu

}
