## Requirements Specification for [Multiplayer Trading Card Game Implementation] ##
## 1. Introduction ##
## 1.1 Purpose of Product ##
We aim to create a 2D multiplayer trading card game using C# and Unity. Our game will include different card types with a few different mechanics. 
Users will have access to mana, which will be used like a currency with which to cast both creature and spell cards to have an effect on the board state. 
Creatures will be able to attack either an enemy creature or the enemy directly during combat. 
The game will end when one player reaches 0 health points or is unable to draw more cards.


## 1.2 Scope of Product ##
## *Product includes : 
-Player vs. player
-Users play with preconstructed decks
-Tally of win/losses during a round
-Play and Exit buttons
-Play cards by dragging and dropping in arena
-Fields for user and enemy hands
-Fields for user and enemy combat zones where cards can be played/dropped
-When a card is hovered over, an enlarged version of it is displayed
-Life totals are displayed
-Coin flip/dice roll buttons
-Concede/Quit button (prompt user for confirmation before leaving the match)

## *Product does not include:
-User decides to play single player mode against an AI bot on easy, medium, or hard difficulty (too complex/not much time to implement)
-No libraries of card lists based on other online card games will be used in our implementation of the card game; we will design our own images and each functionality through Unity 2D.
-In game purchases or application created for monetization purposes under agreement of the Unity 2D and Visual Studio implied licenses that shall be only used for unprofitable community projects abiding by copyright disclaimers under federal law.

## 1.3 Acronyms, Abbreviations, Definitions ##
-Unity 2D : Development platform that can be utilized to create any sort of game or project with enhanced visual features
-Visual Studio: Programming IDE that is synced with Unity 2D that is a basic editor used by developers to create code that meets user requirements and expectations for the project's key components.
-C# Scripts: 
-gamble : use dice rolls or coin flips to randomize card interactions with players or other creatures
-guard : while this card is in play, its owner cannot be attacked directly by creatures
-PvP implementation : two or more players face off in the arena under an online lobby server
-mana: currency that is used in the game to utilize powerful spells that could grant you more damage to attack a player
-leaderboard : tally of wins/losses during a single round
-arena: UI area where each player has their own respective zones to strategize and battle the other player in a game of wits
-main menu: starting screen that will let the user manually start the game or will automatically take the player to this screen if they quit in the middle of a game session

## 1.4 References ##
URL link for project specifications : https://shanhead.github.io/CelestialOctopi/
Requirements Specfication for project template posted on Canvas

## 2. General Description of Product ##

## 2.1 Context of Product ##
We will use C# scripts via Visual Studio IDE that is in sync with the Unity 2D platforming engine in order to create the context of our multiplayer trading card game.

## 2.2 Domain Model with Description ##

Person :    -------------------------------------------------------->     Game Mode :
|            +player                                      + arena          name
|
(Attributes):
username : String
health : int
mana : int
|
|   -----------------------------------   <<Rule>>: If a player does not choose a certain game mode from the main menu, then they are not playing the card game.
|
Card:
type 
name
(Domain class)
          
  
  ## Description of Domain Model ## :
   The attributes of the person who logs into the server is declared as a player, each person having a classified username (type String), amount of intial health (type int), and mana currency (also type int). This links or connects to the primary gameObject of the project known as the card which has both a type and a name. The type classifies what attributes the card can do when the player uses the card in the game, while the name of the card just depicts what the developers have decided to call it. The only available game mode featured in our card game implementation is PvP, or basically an online multiplayer game that matches player with others from around the world. The primary functionality of initial health is to keep track of how much health the player has while playing the game, 



## 2.3 Product Functions (general) ##
Casting cards will require mana, which will be automatically provided at the beginning of a player’s turn and increase every turn until they reach 8
Different card types:
Creatures, which have a mana cost, attack and health values used in combat (you’ll see these written as “x mana y/z”, where x is mana cost, y is attack value, z is the creature’s health)
Spells, which will have a mana cost and affect various aspects of the game.
Players begin the game with 20 health
Players start with 25-card decks and draw hands of 5 cards
Both players will be unable to hold more than 7 cards; if a card was to be drawn while a player already has 7 cards, the card will be discarded
A player will lose when their life total reaches 0 (or fewer) points, runs out of cards, or leaves the game prematurely
Combat between creatures: when a creature attacks another, both creatures inflict their attack value onto the other creature simultaneously. If one or both creatures would survive this damage, it will return to full health at the beginning of the next turn.

## 2.4 User Characteristics and Expectations ##
*New users should be able to start the game and understand the rules and mechanics of the game with ease, without needing to ask for clarification from the development team.
*After holding a small tournament with 8 people, a brief survey will be administered to gauge the players’ feelings on the card game and their experiences should show at least 50% of players had positive feelings about the tournament.
*Two players on separate computers should be able to play a game against one another, with each player only being able to see the cards in their hand and on both players’ sides of the field.
*The creation of at least two 25-card decks which utilize different strategies and will be made available to new players.
*Users can play cards from their hand by dragging and dropping onto their playing field. They should be unable to interact with any cards under the enemy’s control, whether in their hand or on the field, and be unable to move cards from their own field once played.
*A card should be magnified if a user hovers their mouse over it for some duration of time. This enlarged version should appear in a consistent location, and disappear when the user begins to drag the card or moves their mouse away from it.
*Life totals for both players will be accurately displayed throughout the duration of the game.
*The program will be able to facilitate card interactions of an entire game, using card data (manna cost, attack/health, any other effects) without requiring user input outside of normal user decisions.


## 2.5 Constraints ##
1.) Each player should only have access to their own hand and deck, with cards in their hand being obfuscated from their opponent until played.
2.) A user shouldn’t be able to interact with their opponent’s hands or cards on the field, or remove a card from their own field once it has been played.
3.) Magnified copy of the card should disappear if the user begins to drag the card, or moves their mouse away.
4.) This card information will also be easily accessible to the user via user interface of 


## 2.6 Assumptions and Dependencies ##
Our system depends on source code from each C# script that is implemented into the Unity IDE. A brief list of assumptions includes the following for our project:
-Scope
-Scheduling
-Resources
-Time Management
-Expectations
-Technologies
-User testing functionality

## 3. Functional Requirements ##
Userstories page link for CelestialOctopi Project Page : https://shanhead.github.io/CelestialOctopi/userstories

## 4. System and Non-functional Requirements ##
## 4.1 External Interface Requirements (User,Hardware,Software,Communications) ##
Our project implements a Unity UI interface, which is a UI toolkit for developing user interfaces for games and applications. 
It is a GameObject-based UI system that uses Components and the Game View to arrange, position, and style user interfaces.
Developers cannot use Unity UI to create or change user interfaces in the Unity Editor. 
Our programming IDE involves Visual Studio and creating C# scripts to perform certain in-game functionalities. In-game functionalities for the project include, but are not limmited to:
-Casting spells
-Drag and drop functionality
-Roll dice/flip coin to decide a random player that goes first in the game

## 4.1 External Interface Requirements using item numbers ##
NF.4.1.X. User interface : mainly includes elements such as specific competence, criteria action, and response time. Users should be able to play a card and attack an opponent respectively
          if all code runs and compiles without troubleshooting errors, as well as performing testable functions without server delay or any type of bugged running error.
NF.4.1.XI. Software Interface : The system requires a configured PC of either Linux or Windows so that the card game can be run properly on the central processing machine. 
The system must be compatible with running code from Visual Studio utilizing the C# programming language and importing the base code into the UI interface of Unity 2D.
NF.4.1.XII.  Communication Interface :  Data transferred from the server shall use the TCIP/IP protocol over any type of secured Ethernet/WiFi connection. Access to play this game is free for everyone requires a strong stable internet connection to play with others online.

## 4.2 Performance Requirements ##
NF.4.2.X. Code Functionality:  specific competence, criteria action, and response time. For instance, checking how efficient the runtime is running the code for the code structure implemented into our card game project.
NF.4.2.XI. Integrity : availablity of developers to work on components of the project as well as maintenance performance, and other requirements to fulfill such as code maintentance and thorough user testing.
NF.4.2.XII. Reliability/Availability of procedures : Correct and update code functionality that will adhere to all user requirements provided in the problem statement and userstories links on the group project website.

## 4.3 Design Constraints ##
 NF.4.3.X. Game Mechanics should be relatively balanced with each other– that is to say, no mechanic or deck archetype should stand out from the others as being extremely good or weak compared to others. This will require extensive playtesting.
 NF.4.3.XI. Magnified copy of the card should disappear if the user begins to drag the card, or moves their mouse away.
 NF.4.3.XII. Each player should only have access to their own hand and deck, with cards in their hand being obfuscated from their opponent until played.
 

## 4.4 Quality Requirements ##
 NF.4.4.I. Having a game with simple rules and mechanics would be ideal for beginning and intermediate players and allow everyone to enjoy the game, without requiring extensive research to understand rules and strategy.
 NF.4.4.II. Many card games aren’t easily accessible to new players, both in difficulty and financially. We aim to create a game which is freely accessed and which has an intuitive set of rules that can be learned easily.
 NF.4.4.III. In this context, a card game mechanic refers to certain ways that cards interact with each other. When users test card interactions, there should be no functionality issues which implements various cards that are fun and innovative comared to the other card games the user has played.
 NF.4.4.IV. Two players should be able to play against each other in a standard battle type of card game.
 NF.4.5.IV. As a user, I want an interface that doesn’t take a long time to learn, so that I can learn how to play the game more quickly.
 NF.4.6.VI. Developers should create preconstructed decks so that the user will not have to create their own custom deck of cards, leading to anger and frustration testing out the basic game mechanics.


## 4.5 Other User Requirements ##
 NF.4.5.X. A user should be able to play a card by dragging it from their hand and dropping it onto their playing field.
 NF.4.5.XI. If a user hovers over a card, an enlarged version of it should appear on screen for the user to better read
 NF.4.5.XII. As a player, I want the game to keep track of game data and statistics so that the user is free to focus on playing the game.
 NF.4.5.XIII. The game should pay attention to both players’ life totals and display them on screen, and use that information to help determine whether the game has ended.
 NF.4.5.XIV. Card information like a spell’s mana cost and effect, or a creature’s attack and health values, should be stored by the game and used to handle card interaction (like in combat).
 

## 5. Appendices ##
Include external documents that describe domain or constraints or any necessary information. Use URL links if possible.

-Architecture of card game project : https://shanhead.github.io/CelestialOctopi/architecture (page will be updated as part of project requirements)
-Design document URL link : https://shanhead.github.io/CelestialOctopi/design (page will be updated as part of project requirements)
