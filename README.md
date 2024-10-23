# TowerDefense
# TowerDefenseTemplate
 **Verwijder uiteindelijk de template teksten!**

Begin met een korte omschrijving van je towerdefense game en hoe deze werkt. Plaats ook een paar screenshots.

Bij mijn spel moet je aliens gaan vernietigen en steeds meer torens plaatsen met score punten. Groene aliens gaan de torens aanvallen and je moet zo lang mogelijk kunnen overleven.
![MainGame](https://github.com/FelixHuiskamp/TowerDefense/blob/main/ScreenShots/Game.png?raw=true)

![MainMenuTitle](https://github.com/FelixHuiskamp/TowerDefense/blob/main/ScreenShots/TitleScreen.png?raw=true)


## Product 1: "DRY SRP Scripts op GitHub"

In deze script heb ik een wave manager gemaakt die aliens spawnt. Deze script is dus DRY omdat de script alle aliens aanstuurt met waves
[link naar script](https://github.com/FelixHuiskamp/TowerDefense/blob/main/Assets/Scripts/Alien/WaveManager.cs)"*

## Product 2: "Projectmappen op GitHub"



Dit is de [ROOT](https://github.com/FelixHuiskamp/TowerDefense/tree/main/Assets) folder van mijn unity project.



## Product 3: Build op Github



[Release](https://github.com/FelixHuiskamp/TowerDefense/releases/tag/Unity)

## Product 4: Game met Sprites(animations) en Textures 



Ik heb AI gebruikt om een sprite te maken voor de turret. De alien sprite heb ik van internet gehaald.

![Sprites gif](https://github.com/FelixHuiskamp/TowerDefense/blob/main/ScreenShots/TowerDefenseGame.gif?raw=true)

## Product 5: Issues met debug screenshots op GitHub 

Zodra je bugs tegenkomt maak je een issue aan op github. In de issue omschrijf je het probleem en je gaat proberen via breakpoints te achterhalen wat het probleem is. Je maakt screenshot(s) van het debuggen op het moment dat je via de debugger console ziet wat er mis is. Deze screenshots met daarbij uitleg over het probleem en de bijhorende oplossing post je in het bijhorende github issue. 
[Hier de link naar mijn issues](https://github.com/erwinhenraat/TowerDefenseTemplate/issues/)

## Product 6: Game design met onderbouwing 


*  **Je game bevat torens die kunnen mikken en schieten op een bewegend doel.** 

*Mijn game bevat torens die automatisch schieten naar aliens en bevatten een target systeem*
*  **Je game bevat vernietigbare vijanden die 1 of meerderen paden kunnen volgen.**  

*Mijn game bevat vernietigbare aliens die de torens aanvallen vanuit een positie waar ze met waves aankomen*

*  **Je game bevat een “wave” systeem waarmee er onder bepaalde voorwaarden (tijd/vijanden op) nieuwe waves met vijanden het veld in komen.**

*Mijn game bevat een oneidig wave systeem en de game is pas klaar als al je torens zijn vernietigd.*

*  **Een “health” systeem waarmee je levens kunt verliezen als vijanden hun doel bereiken en zodoende het spel kunt verliezen.** 

*De torens nemen damage en het spel stopt zodra alle torens kapot zijn*

*  **Een “resource” systeem waarmee je resources kunt verdienen waarmee je torens kunt kopen en .evt upgraden.**

*Mijn spel bevat een score systeem waar je met elke 50 punten een toren kan plaatsen*

*  **Een “upgrade” systeem om je torens te verbeteren.**

*Ik heb geen upgrade systeem gemaakt*

*  **Een “movement prediction” systeem waarmee je kan berekenen waar een toren heen moeten schieten om een bewegend object te kunnen raken. (Moeilijk)**

*Ik heb deze mechanic niet gemaakt*

## Product 7: Class Diagram voor volledige codebase 


## Product 8: Prototype test video


## Product 9: SCRUM planning inschatting 

[Link naar de openbare trello](https://trello.com/b/Q2CNoEC2/felix-tower-defense)

## Product 10: Gitflow conventions

N.V.T.
