#include <DHT.h>

//DHT temp sensor PINS
#define DHTPIN 2 

//RGB PINS
#define BLUE 3
#define GREEN 5
#define RED 6

#define DHTTYPE DHT11

// c programing language
 
 


DHT dht(DHTPIN, DHTTYPE);


void setup() {

  Serial.begin(9600);
  dht.begin();

  // Set pinmode
  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);
  pinMode(BLUE, OUTPUT);

}

void loop() {
   delay(500);
   //float h = dht.readHumidity();
   float t = dht.readTemperature();
  
  if(isnan(t) ) {
      return;
  }

  if(Serial.available()){
    char charCmd = Serial.read();
     switch(charCmd){
       case 'R':
        digitalWrite(RED, HIGH);
        digitalWrite(GREEN, LOW);
        digitalWrite(BLUE, LOW);
       break;
       case 'G':
        digitalWrite(RED, LOW);
        digitalWrite(GREEN, HIGH);
        digitalWrite(BLUE, LOW);
       break;
       case 'B':
        digitalWrite(RED, LOW);
        digitalWrite(GREEN, LOW);
        digitalWrite(BLUE, HIGH);
       break;
      case 'O':
        digitalWrite(RED, LOW);
        digitalWrite(GREEN, LOW);
        digitalWrite(BLUE, LOW);
      break;
     }
  }

   Serial.println(t);
   //Serial.println(h)

}
