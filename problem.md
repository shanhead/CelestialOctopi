## Problem Statement ##
### Summary ###
We aim to create a 2D multiplayer trading card game using C# and Unity. Our game will include different card types with a few different mechanics. Users will have access to mana, which will be used like a currency with which to cast both creature and spell cards to have an effect on the board state. Creatures will be able to attack either an enemy creature or the enemy directly during combat. The game will end when one player reaches 0 health points or is unable to draw more cards.

### Game Rules and Mechanics ###
* Casting cards will require mana, which will be automatically provided at the beginning of a player's turn and increase every turn until they reach 8
* Different card types:
   - Creatures, which have a mana cost, attack and health values used in combat (you'll see these written as "x mana y/z", where x is mana cost, y is attack value, z is the creature's health)
   - Spells, which will have a mana cost and affect various aspects of the game.
* Players begin the game with 20 health
* Players start with 25-card decks and draw hands of 5 cards
* Both players will be unable to hold more than 7 cards; if a card was to be drawn while a player already has 7 cards, the card will be discarded
* A player will lose when their life total reaches 0 (or fewer) points, runs out of cards, or leaves the game prematurely
* Combat between creatures: when a creature attacks another, both creatures inflict their attack value onto the other creature simultaneously. If one or both creatures would survive this damage, it will return to full health at the beginning of the next turn.

### Game Features ###
* Player vs. player
* Users play with preconstructed decks
* Tally of win/losses during a round
* Main menu:
   - Play and Exit buttons
   - Play takes the user to the arena
* Arena:
   - Play cards by dragging and dropping
   - Fields for user and enemy hands
   - Fields for user and enemy combat zones where cards can be played/dropped
   - When a card is hovered over, an enlarged version of it is displayed
   - Life totals are displayed
   - Coin flip/dice roll buttons
   - Concede/Quit button (prompt user for confirmation before leaving the match)

### Sample Cards and Card Mechanics ###
* Proposed mechanics:
  - **gamble** : use dice rolls or coin flips to randomize card interactions with players or other creatures
  - **guard** : while this card is in play, its owner cannot be attacked directly by creatures
* Creatures:
  - 1 mana 1/3 : whenever you cast a spell, this creature gets +1 attack
  - 3 mana 2/3 : while this creature is in play, its owner's other creatures have +1 health
  - 5 mana 5/5 : **guard**  
* Spells:
  - 1 mana: Deal 3 damage to target creature or player
  - 3 mana: Restore 5 health to target creature or player
  - 1 mana: **gamble** Flip a coin. Heads, draw a card. Tails, your opponent draws a card.

### Sample Arena ###
![Concept Arena](SampleBattle.png "What a game might look like")
