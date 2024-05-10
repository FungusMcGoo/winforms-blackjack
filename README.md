Simple Version of Blackjack created to practise and learn functions of VB.NET as well as Visual Studio.

Added a pirate flair to the game to add some personality and allow for me to play around with more creative design elements of the project.

Project is based around the first project in this VB.NET Blackjack guide: https://www.codeguru.com/visual-basic/creating-a-blackjack-game-in-visual-basic/ 

**As is the guide is not a properly functioning game of Blackjack, but an outline of the creation of Blackjack, the following changes have needed to be made:**
  1) Properly initialise the 'Random' instance as a shared variable to ensure random numbers are generated correctly.
  2) Implement correct 'Hit' logic: check if the player has exceeded the maximum of 21, triggering the 'Bust' scenario.
  3) Implement correct 'Stand' logic: instead of simply comparing the cards, the dealer typically draws cards until they reach 17 or higher and then must stand.
  4) Hit and Stand buttons are disabled in the 'Game_Load' event handler to preventing the players actions before the cards are dealt. Buttons are then re-enabled in the 'Button_deal_click' event handler.

**Future implementations:**
  1) A fully fleshed out point system, allowing the player to accumulate and lose points, increase bet amounts, double down, and possibly save the accumulation of points until the player wishes to play again.
  2) Implementing the second part of the above linked project to simulate some type of physical card play
  3) Refining the UI, adding better graphical elements, sound effects, and whatever other polish can be easily squeezed into the game to improve the viewing experience for the player
