# RacingGame

Widows forms project by : Darko Romovski 153132 and Martin Peshovski 156011.

## 1. Опис

Во овој проект креиравме игра во која корисникот вози еден автомобил, каде целта е да се избегне удар со други автомобили, и притоа да се собираат парички и гориво.

## 2. Упатство

### 2.1 Нова игра

  - Со Кликање на Start Game, се бира на кое ниво корисникот сака да игра, и има можност да избере од:
    Easy,
    Normal,
    Hard.
  - Со избирање на нивото, корисникот продолжува да ја игра играта.
  - Секое од овие нивоа, носи своја брзина со која автомобилот иницијално почнува да вози, и може само да се забрзува.

### 2.2 Правила

  - Играчот треба да ги избегнува другите автомобили за да не му заврши играта.
  - Играчот треба да ги собира паричките кои го сочинуваат score-от кога ќе заврши играта.
  - Играчот треба да ги собира кантите со гориво, за да продолжи да го вози автомобилот.

## 3. Претставување на проблемот

### 3.1 Податочни структури

Главните податоци и функции се чуваат во класите `Form1`, `Car`, `Coin`, `Fuel`.


#### 3.1.1 Form1

`Form1` класата ни е главната класа, каде сите други класи се искористуваат.
Во класата Form1 се чуваат параметри, како што се `List<Car> cars`, `List<Coin> coins`, `Fuel f` како и некои констати кои ги употребуваме во оваа класа.
Овие параметри ги пополнуваме во функцијата `initLists` која ја повикуваме на инцијализација на оваа форма.

#### 3.1.2 Car

Во оваа класа се чуваат податоци за автомобилите како што се `public Point location` и во конструкторот на класата `Carс` е креира нов `Point`, `public Image carImage` каде ја поставуваме сликата на автомобилот, `Rectangle car`.

#### 3.1.3 Coin

Во оваа класа се чуваат податоци за паричките кои ги собира корисникот.

#### 3.1.4 Fuel 

Во оваа класа се чуваат податоците за гориво.

### 3.2 Фунцкии

#### 3.2.1 Form1

Во оваа класа користиме неколку функции од кои `initList()`, `startGame()`, `fuelUp()`, `coinsUp()`, `GameOver()`.

Функцијата `initList()` се повикува на иницијализација на класата, и со неа ги сетираме потребните параметри, како што се листата со автомобили, линии, парички.

Со функцијата `startGame()` ја почнуваме играта.

Со `fuelUp()` го накачуваме прогрес барот при земање на гориво.

Сo `coinsUp()` го накачуваме бројот на парички.

Во оваа фунцкија, ги сетираме сите листи и потребни параметри, и се повикува при иницијализација на класата.

Во оваа функција , при секој клик на копчињата за горе, доле, лево и десно, ја поместуваме нашиот автомобил.

#### 3.2.2 Car

Во оваа класа имаме неколку функции од кои `Drive()`, `Draw()`, `setImage()`, `restartCars()`, `isHit()`.

Функцијата `Drive()` ја повикуваме од класата Form1, и во неа ја поместуваме позицијата на автомобилот, спред аргументите кои се пратени во функцијата.

Со функцијата  `Draw()` го исцртуваме квадратот, кој ќе го претставува автомобилот.

Со функцијата `setImage()` ја сетираме сликата на автомобилот.

Со функцијата `restartCars()` ја рестартираме позицијата на автомобилот, на некоја рандом позиција.

Со функцијата `isHit()` проверуваме дали нашиот автомобил удрил во некој друг автомобил.


## 4 GUI
<img src="RacingGame/playing.png" width="350" title="hover text">



