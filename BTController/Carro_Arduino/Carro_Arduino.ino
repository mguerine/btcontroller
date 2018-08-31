/* --- PROJETO EXPOCANP: CONSTRUINDO UM PROTÓTIPO DE CARRO AUTÔNOMO UTILIZANDO A PLATAFORMA ARDUINO ---
 * CÓDIGO CRIADO COM BASE EM CÓDIGOS DOS AUTORES: http://seurobo.com.br/ E http://www.usinainfo.com.br/
 */

#include <Servo.h>    // inclui biblioteca de manipulação de servos motores.    
#include <AFMotor.h>   // inclui biblioteca de manipulação de motores DCs.  
    
//Definindo os pinos  
#define trigPin A0 //Pino TRIG do sensor no pino analógico A0
#define echoPin A1 //Pino ECHO do sensor no pino analógico A1
#define BUZZER A2  // Define o pino do buzzer (Som) no pino ANALÓGICO A0
AF_DCMotor motor1(1);    // Define o motor1 ligado ao M1  
AF_DCMotor motor2(2);    // Define o motor2 ligado ao M2  

int TempoGirar = 1;//Esse é o tempo para o robô girar em 45º com uma bateria de 9v.
int distanciaObstaculo = 30; //Distância para o robô parar e recalcular o melhor caminho
int velocidadeMotores = 80; //Velocidade que os motores funcionarão na bateria 9v. Para a bateria 9v a velocidade 80 é ideal
Servo servo_ultra_sonico; //Nomeando o servo motor    

//Variáveis  para o sensor ultrassonico
long duracao;
long distancia_cm = 0;
int minimumRange = 5; //Tempo de resposta do sensor
int maximumRange = 200;

const int BTState = 2;    // Define o Pino 2 como o pino de comunicação do Bluetooth.

// Variáveis Úteis
int i = 0;
int j = 0;
int state_rec;
int vSpeed = 200;   // Define velocidade padrão 0 < x < 255.
char state;
char car_mode = 'M';

void setup(){
  Serial.begin(9600); // Inicializa a comunicação serial para mostrar dados     
  servo_ultra_sonico.attach(10);  // Define o mini servo motor ligado no pino digital 10.    
  pinMode(trigPin, OUTPUT); //Define o pino TRIG como saída
  pinMode(echoPin, INPUT);  // Define o pino ECHO como entrada 
  pinMode(BUZZER, OUTPUT);   // Define o pino do buzzer como saída
  pinMode(BTState, INPUT); 
  motor1.setSpeed(velocidadeMotores);     // Define a velocidade para os motores. A velocidade máxima é 255. 
  motor2.setSpeed(velocidadeMotores);     // Usamos uma bateria de 9v 450mAh, com ela a velocidade ficou boa. Mas dependendo da bateria utilizada a velocidade deverá ser utilizada. Não use pilhas, pois são fracas
  servo_ultra_sonico.write(90);   // O servo do sensor se inicia a 90 graus (meio)    
  rotacao_Parado;  // Inica com os motores parados
}

void loop(){
  // Para o carro quando a conexão com Bluetooth é perdida ou desconectada.
  if (digitalRead(BTState) == LOW) {
    state_rec = 'S';
    car_mode = 'M';
  }

  // Salva os valores da variável 'state'
  if (Serial.available() > 0) {
    state_rec = Serial.read();
    state = state_rec;
    //   Serial.println(vSpeed);
    
    if(state == 'X'){
      car_mode = 'A';
    }
    if(state == 'x'){
      car_mode = 'M';
    }
  }


  if (car_mode == 'A') {
      reposicionaServoSonar(); //Coloca o servo para olhar a frente    
      int distancia = lerSonar(); // Ler o sensor de distância  
      Serial.print("distancia em cm: "); 
      Serial.println(distancia);   // Exibe no serial monitor 
      if (distancia > distanciaObstaculo) {  // Se a distância for maior que 20 cm  
        rotacao_Frente(); //robô anda para frente   
      }else{   
        rotacao_Parado();  //para o robô  
        posicionaCarroMelhorCaminho(); //calcula o melhor caminho    
        //pensar();    
      } 
  }
  if(car_mode == 'M'){
    // Altera a velocidade de acordo com valores especificados.
    if (state == '0') velocidadeMotores = 0;
    else if (state == '1') velocidadeMotores = 10;
    else if (state == '2') velocidadeMotores = 20;
    else if (state == '3') velocidadeMotores = 30;
    else if (state == '4') velocidadeMotores = 40;
    else if (state == '5') velocidadeMotores = 50;
    else if (state == '6') velocidadeMotores = 60;
    else if (state == '7') velocidadeMotores = 70;
    else if (state == '8') velocidadeMotores = 80;
    else if (state == '9') velocidadeMotores = 90;
    else if (state == 'q') velocidadeMotores = 100;
    
    if (state != 'S') {
      Serial.print(state);
    }
  
    // Se o estado recebido for igual a 'F', o carro se movimenta para frente.
    if (state == 'F') {
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(FORWARD);
      motor2.run(FORWARD);
    }
  
    else if (state == 'I') {  // Se o estado recebido for igual a 'I', o carro se movimenta para Frente Esquerda.
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(100 * 0.4);
      motor1.run(FORWARD);
      motor2.run(FORWARD);
    }
  
    else if (state == 'G') {   // Se o estado recebido for igual a 'G', o carro se movimenta para Frente Direita.
      motor1.setSpeed(100 * 0.4);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(FORWARD);
      motor2.run(FORWARD);
    }
  
    else if (state == 'B') { // Se o estado recebido for igual a 'B', o carro se movimenta para trás.
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(BACKWARD);
      motor2.run(BACKWARD);
    }
  
     else if (state == 'H') {  // Se o estado recebido for igual a 'H', o carro se movimenta para Trás Esquerda.
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(100 * 0.4);
      motor1.run(BACKWARD);
      motor2.run(BACKWARD);
    }
    
    else if (state == 'J') {  // Se o estado recebido for igual a 'J', o carro se movimenta para Trás Direita.
      motor1.setSpeed(100 * 0.4);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(BACKWARD);
      motor2.run(BACKWARD);
    }
  
    else if (state == 'L') {   // Se o estado recebido for igual a 'L', o carro se movimenta para esquerda.
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(BACKWARD);
      motor2.run(FORWARD);
    }
    else if (state == 'R') {   // Se o estado recebido for igual a 'R', o carro se movimenta para direita.
      motor1.setSpeed(velocidadeMotores);
      motor2.setSpeed(velocidadeMotores);
      motor1.run(FORWARD);
      motor2.run(BACKWARD);
    }
    else if (state == 'S') {   // Se o estado recebido for igual a 'S', o carro permanece parado.
      Serial.println(" Motor: Parar ");
      motor1.run(RELEASE); // Motor para  
      motor2.run(RELEASE);
    }
  
    else if (state == 'V') { // Se o estado recebido for iguala 'V', aciona a buzina.
      if (j == 0) {
        digitalWrite(BUZZER, HIGH); // Liga o som
        j = 1;
      }
      else if (j == 1) {
        digitalWrite(BUZZER, LOW); // Liga o som
        j = 0;
      }
      state = 'n';
    }
  }
}

  // Função para chamar outras funções e definir o que o robô fará  
void pensar(){    
}  
    
// Função para ler e calcular a distância do sensor ultrassônico    
int lerSonar(){    
  digitalWrite(trigPin, LOW); //não envia som
  delayMicroseconds(2);
  digitalWrite(trigPin,HIGH); //envia som 
  delayMicroseconds(10);
  digitalWrite(trigPin,LOW); //não envia o som e espera o retorno do som enviado
  duracao = pulseIn(echoPin,HIGH); //Captura a duração em tempo do retorno do som.
  distancia_cm = duracao/56; //Calcula a distância
  delay(30);  
  return distancia_cm; // Retorna a distância  
}   
    
// Função para calcular a distância do centro    
int calcularDistanciaCentro(){    
  servo_ultra_sonico.write(90);    
  delay(20);   
  int leituraDoSonar = lerSonar();  // Ler sensor de distância  
  delay(500);   
  leituraDoSonar = lerSonar();   
  delay(500);   
  Serial.print("Distancia do Centro: "); // Exibe no serial  
  Serial.println(leituraDoSonar);   
  return leituraDoSonar;       // Retorna a distância  
}    
    
// Função para calcular a distância da direita    
int calcularDistanciaDireita(){    
  servo_ultra_sonico.write(0);   
  delay(200);  
  int leituraDoSonar = lerSonar();   
  delay(500);   
  leituraDoSonar = lerSonar();   
  delay(500);   
  Serial.print("Distancia da Direita: ");  
  Serial.println(leituraDoSonar);   
  return leituraDoSonar;    
}    
    
// Função para calcular a distância da esquerda    
int calcularDistanciaEsquerda(){    
  servo_ultra_sonico.write(180);   
  delay(200);  
  int leituraDoSonar = lerSonar();   
  delay(500);   
  leituraDoSonar = lerSonar();   
  delay(500);   
  Serial.print("Distancia Esquerda: ");  
  Serial.println(leituraDoSonar);   
  return leituraDoSonar;    
}    
    
// Função para captar as distâncias lidas e calcular a melhor distância. Acesse: Seu Robô http://seurobo.com.br/    
char calculaMelhorDistancia(){    
  int esquerda = calcularDistanciaEsquerda();    
  int centro = calcularDistanciaCentro();    
  int direita = calcularDistanciaDireita();
  reposicionaServoSonar();    
  int maiorDistancia = 0;
  char melhorDistancia = '0';  
  if (centro > direita && centro > esquerda){    
    melhorDistancia = 'c';    
    maiorDistancia = centro;    
  }else   
  if (direita > centro && direita > esquerda){    
    melhorDistancia = 'd';    
    maiorDistancia = direita;    
  }else  
  if (esquerda > centro && esquerda > direita){    
    melhorDistancia = 'e';    
    maiorDistancia = esquerda;    
  }
  if (maiorDistancia <= distanciaObstaculo) { //distância limite para parar o robô   
    rotacao_Re();    
    posicionaCarroMelhorCaminho();    
  }    
  reposicionaServoSonar();  
  return melhorDistancia;    
}    
    
// Função para colocar o carrinho na melhor distância, isto é, girá-lo para a melhor distância    
void posicionaCarroMelhorCaminho(){    
  char melhorDist = calculaMelhorDistancia();     
  Serial.print("melhor Distancia em cm: ");  
  Serial.println(melhorDist);  
  if (melhorDist == 'c'){    
     motor1.run(FORWARD);
     motor2.run(FORWARD); 
  }else if (melhorDist == 'd'){    
    rotacao_Direita();    
  }else if (melhorDist == 'e'){    
     rotacao_Esquerda();     
  }else{    
    rotacao_Re();    
  }    
  reposicionaServoSonar();    
}    
    
// Função para deixar o sensor "olho" do robô no centro    
void reposicionaServoSonar(){    
  servo_ultra_sonico.write(90);   
  delay(200);   
}    
    
// Função para fazer o carro parar    
void rotacao_Parado(){    
  Serial.println(" Motor: Parar ");
  motor1.run(RELEASE); // Motor para  
  motor2.run(RELEASE);  
}    
      
// Função para fazer o robô andar para frente    
void rotacao_Frente(){    
  Serial.println("Motor: Frente ");   
  motor1.run(FORWARD); // Roda vai para frente  
  motor2.run(FORWARD);   
  //delay(50);    
}    
      
// Função que faz o robô andar para trás e emite som quando ele dá ré    
void rotacao_Re(){    
  Serial.println("Motor: ré ");  
  for (int i=0; i <= 3; i++){
     digitalWrite(BUZZER, HIGH); // Liga o som
     delay(100);
     motor1.run(BACKWARD);    // Roda vai para trás  
     motor2.run(BACKWARD);    // Roda vai para trás  
     delay(100);  
     digitalWrite(BUZZER, LOW); // Desliga o som  
     delay(100);
  } 
  rotacao_Parado();    
}    
    
// Função que faz o robô virar à direita, http://loja.seurobo.com.br/    
void rotacao_Direita(){    
  digitalWrite(BUZZER, HIGH); // Liga o som
  delay(100);
  motor1.run(BACKWARD);    //o robô dá uma ré para não colidir ao girar 
  motor2.run(BACKWARD);      
  delay(50);  
  digitalWrite(BUZZER, LOW); // Desliga o som  
  delay(100);
  Serial.println(" Para a direita ");  
  motor1.run(FORWARD); // Roda vai para frente  
  motor2.run(BACKWARD); // Roda vai para trás   
  delay(TempoGirar);    
}    
      
// Função que faz o robô virar à esquerda    
void rotacao_Esquerda(){    
  digitalWrite(BUZZER, HIGH); // Liga o som
  delay(100);
  motor1.run(BACKWARD);    // // O robô dá uma ré para não colidir ao girar 
  motor2.run(BACKWARD);   
  delay(50);  
  digitalWrite(BUZZER, LOW); // Desliga o som  
  delay(100);
  Serial.println(" Para a esquerda ");  
  motor1.run(BACKWARD); // Roda vai para trás  
  motor2.run(FORWARD); // Roda vai para frente  
  delay(TempoGirar);    
}  






