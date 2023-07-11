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

int length;

SR04 Usonic = SR04(ECHO_PIN,TRIG_PIN);

DHT dht(DHTPIN, DHTTYPE);


void setup() {

  Serial.begin(9600);
  dht.begin();

  // Set pinmode
  pinMode(RED, OUTPUT);
  pinMode(GREEN, OUTPUT);
  pinMode(BLUE, OUTPUT);

  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);

}

void loop() {
    delay(500);

    //Temp Sensor
    int t = dht.readTemperature();
  
    // send only valid data, the sensor cannot send more than 50 
    if(!isnan(t) && (t >= -10) && (t <= 50)  ) {
        Serial.println("tem," + String(t)); 
    }
    
    
    // Ultrasonic
    length = Usonic.Distance();
  //send only valid data, the sensor cannot send more than 400 
    if(!isnan(length) && (length >= 0) && (length <= 400)  ) {
        Serial.println("uls," + String(length)); 
    }

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
