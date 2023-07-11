#include <SR04.h>
#include <DHT.h>


//DHT Temp Sensor PINS
#define DHTPIN 2 

//RGB PINS
#define BLUE 3
#define GREEN 5
#define RED 6

// Ultrasonic Sensor PINS
#define TRIG_PIN 12
#define ECHO_PIN 11

#define DHTTYPE DHT11

SR04 Usonic = SR04(ECHO_PIN,TRIG_PIN);
int length;
 
 


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

    //Temp Sensor
    int t = dht.readTemperature();
  
    if(isnan(t) ) {
        return;
    }
    
    //Serial.println(t);
    
    // Ultrasonic
    length = Usonic.Distance();
    Serial.println(length);

    //LED color
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



}
