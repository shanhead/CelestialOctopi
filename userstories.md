## User Stories

* ### 1: Game Format

 * #### 1.1 : Intuitive Ruleset
   **As a casual card game player, I want a game that is relatively easy to learn and understand, so that I can easily jump in and play.**  
   *Elaboration:* Having a game with simple rules and mechanics would be ideal for beginning and intermediate players and allow everyone to enjoy the game, without requiring extensive research to understand rules and strategy.  
   *Constraints:* None  
   *Effort Estimation:* 4 person-hours  
   *Acceptance Test:* New users should be able to start the game and understand the rules and mechanics of the game with ease, without needing to ask for clarification from the development team.  

 * #### 1.2: Easily Accessible
   **As a tournament organizer, I want a game that community members and others can pick up quickly for casual tournaments, so that more people might join in our game nights and other events.**  
   *Elaboration:* Many card games aren't easily accessible to new players, both in difficulty and financially. We aim to create a game which is freely accessed and which has an intuitive set of rules that can be learned easily.  
   *Constraints:* None  
   *Effort Estimation:* 2 person-hours  
   *Acceptance Test:* After holding a small tournament with 8 people, a brief survey will be administered to gauge the players' feelings on the card game and their experiences should show at least 50% of players had positive feelings about the tournament.

* ### 2: Game Mechanics and Archetypes
 **As an experienced card game player, I want to use game mechanics that are fun and innovative, so that it stands out from other games I've played.**  
 *Elaboration:* In this context, a card game mechanic refers to certain ways that cards interact with each other. For example, several cards might all share a certain effect, which might also synergize with other cards of its type. A deck might be built around this mechanic, and this would create a deck archetype.  
 *Constraints:* Mechanics should be relatively balanced with each other-- that is to say, no mechanic or deck archetype should stand out from the others as being extremely good or weak compared to others. This will require extensive playtesting.  
 *Effort Estimation:* 2 person-hours  
 *Acceptance Test:* Beta testers will be introduced to the rules and asked to play a few games with each other; a subsequent survey on their enjoyment of the game should show that at least 50% felt positively about their experiences with game mechanics.  

* ### 3: Player vs. Player Functionality
 **As a player, I want to be able to play against other people because it's a challenge.**  
 *Elaboration:* Two players should be able to play against each other in a card game  
 *Constraints:* Each player should only have access to their own hand and deck, with cards in their hand being obfuscated from their opponent until played.  
 *Effort Estimation:* 4 person-hours  
 *Acceptance Test:* Two players on separate computers should be able to play a game against one another, with each player only being able to see the cards in their hand and on both players' sides of the field.  

* ### 4: Preconstructed Decks
 **As a new card player, I want to be able to play with ready-made decks, so that learning the rules of the game can be less stressful.**   
 *Elaboration:* Deckbuilding can be a stressful experience for new players (particularly those new to card games) who don't yet have a grasp on game rules or mechanics. If they build a suboptimal deck and lose repeatedly, it can lead to frustration Therefore, they should be provided the option of ready-made, balanced decks with which to learn.  
 *Constraints:* None  
 *Effort Estimation:* 6 person-hours  
 *Acceptance Test:* The creation of at least two 25-card decks which utilize different strategies and will be made available to new players.  

* ### 5 : Intuitive UI
 **As a user, I want an interface that doesn't take a long time to learn, so that I can learn how to play the game more quickly.**
 * #### 5.1: Drag and Drop Functionality
   **As a user, I want to be able to interact with my cards by dragging and dropping them because that's the most intuitive interface for me.**  
    *Elaboration:* A user should be able to play a card by dragging it from their hand and dropping it onto their playing field.  
    *Constraints:* A user shouldn't be able to interact with their opponent's hands or cards on the field, or remove a card from their own field once it has been played.  
    *Effort Estimation:* 3 person-hours  
    *Acceptance Test:* Users can play cards from their hand by dragging and dropping onto their playing field. They should be unable to interact with any cards under the enemy's control, whether in their hand or on the field, and be unable to move cards from their own field once played.  

 * #### 5.2: Zoom on Hover
   **As a user, I want cards to magnify themselves so that I can read them more clearly.**
   *Elaboration:* If a user hovers over a card, an enlarged version of it should appear on screen for the user to better read.  
   *Constraints:* Magnified copy of the card should disappear if the user begins to drag the card, or moves their mouse away.  
   *Effort Estimation:* 1 person-hour  
   *Acceptance Test:* A card should be magnified if a user hovers their mouse over it for some duration of time. This enlarged version should appear in a consistent location, and disappear when the user begins to drag the card or moves their mouse away from it.  

* ###  6: Statistics Tracking
 **As a player, I want the game to keep track of game data and statistics so that I'm free to focus on playing the game.**
 * #### 6.1 : Life Totals
   **As a player, I want the game to keep track of mine and my opponent's life totals, so that I can focus on game strategy.**  
   *Elaboration:* The game should pay attention to both players' life totals and display them on screen, and use that information to help determine whether the game has ended.  
   *Constraints:* None.  
   *Effort Estimation:* 1 person-hour  
   *Acceptance Test:* Life totals for both players will be accurately displayed throughout the duration of the game.  

 * #### 6.2: Card Stats
   **As a player, I want the game to store card data for me and have it readily accessible so that I don't need to remember every card.**  
   *Elaboration:* Card information like a spell's manna cost and effect, or a creature's attack and health values, should be stored by the game and used to handle card interaction (like in combat).  
   *Constraints:* This card information will also be easily accessible to the user via   
   *Effort Estimation:* 2 person-hours  
   *Acceptance Test:* The program will be able to facilitate card interactions of an entire game, using card data (manna cost, attack/health, any other effects) without requiring user input outside of normal user decisions.
   
  
  
  * ###  7: Combat defense mechanincs
 **As a player, I want the game to keep track of how much damage I can give and receive to/from my opponent in the game using either normal attacks or spell attacks.**
 * #### 7.1 : Damage Taken
   **As a player, I want the game to keep track of mine and my opponent's life totals, so that I can focus on game strategy.**  
   *Elaboration:* The game should pay attention to both players' life totals and display them on screen, and determine when a player gets damaged by an incoming attack from another player. Various cards will have at least taken away 1-3 HP from the player who had just been attacked by that respective card.  
   *Constraints:* None.  
   *Effort Estimation:* 2 person-hours  
   *Acceptance Test:* Incoming damage value will be enhanced and therefore decreases the players's life total by the indicated damage amount on each card played by a user.

 * #### 7.2: Guard (block) Card Functionality
   **As a player, I want the game to contain the proper functionality for the guard card so that I can block incoming damage from my opponent.**  
   *Elaboration:* Damage should not be sustained to a player if the guard card is enabled. It's status effects are temporary up to only one turn and should act like a shield to                   prevent the player from sustaining any sort of damage inflicted upon them by the opponeent.  
   *Constraints:* None
   *Effort Estimation:* 1 person-hours  
   *Acceptance Test:* Users should test the guard card functionality within the UI and check to see if the card performs a reduced damage functionality or nearly does anything at all, meaning that the game developers did not implement the functionality correctly into the coded software structure.
   
   * ###  8: Undelayed functionality
 **As a player, I want the game to run without any bugged glitches or errors so that I can enjoy the overall experience of the game.**
 * ### 8.1 : No Server Crashes
   **As a player, I want the game to keep implement a stable server so that there are no crashes when there are multiple players on the application simultaneously.**  
   *Elaboration:* The developers should constantly debug their code block by block and ensure that it is free of runtime complexity errors to check for any glitches embedded                       into the system software .  
   *Constraints:* None.  
   *Effort Estimation:* 3 person-hours  
   *Acceptance Test:* An abundance of users throughly test and play the game for around a couple of hours and ensure that the system does not crash when multiple users are       synced to the same server.


 * ###  9: Enjoyable Family-Friendly Experience
 **As a parent to a son who’s big on trading card games I have been looking for an online based game that
my son and his friends can play together. **
* ### 9.1 Fun to Play
      ** As a parent, With such a busy schedule it’s difficult to make time to get
them all together to play as often as they want. With an online trading card game like this one I’m
hoping to help them enjoy playing even if everyone is unable to make it to a get-together.

*Elaboration:* As a parent with a busy schedule its not always easy to make the time to take my son to
meet with his friends and play the card games he enjoys. With this game I’m hopeful that when meeting
in person isn’t possible this game will allow him to play against his friends just as he would in person
without the worry of not being able to make it due to scheduling issues.
*Constraints:* none
*Effort Estimation:* 52 person-hours (whole development of project)
*Acceptance Test:*  A game that allows my son and his friends to play the trading card games they enjoy
even if a busy schedule doesn’t allow for meeting in person. As long as the game is fun and runs reliably
I believe it will be perfect for them to have something to play at any time.


* ###  10: Social Hobby that connects friends together
 **As a parent to a son who’s big on trading card games I have been looking for an online based game that
my son and his friends can play together. **
* ### 10.1 Stress Reliever pertaining to modern-day life occupation roles
      ** As a full-time college student working a part-time job I don’t always have a lot of time to spare. I’m
hoping that with this game I’ll be able to play against my friends with any spare time I do have even if
not a lot.
*Elaboration:* One of my favorite hobbies is playing trading card games with a group of my friends. Lately
due to an overload of school work and working extra hours its been very difficult finding time to play
with my friends as I normally would. I’m hoping that with this game I’ll be able to fit in a few games with
them whenever possible during a break at work or during my homework.
*Constraints:* None
*Effort Estimation:* 5 person-hours to 
*Acceptance Test:* I’m hoping for a simple card game that I can play with my friends. Hopefully a trading
card game that can be played in a short time rather than taking hours to complete that way I can play
even if I don’t have a lot of time to do so. 
   

   
   
   
