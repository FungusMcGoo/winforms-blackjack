Simple Version of Blackjack created to practise and learn functions of VB.NET as well as Visual Studio.

Added a pirate flair to the game to add some personality and allow for me to play around with more creative design elements of the project.
Project is based around the first project in this VB.NET Blackjack guide: https://www.codeguru.com/visual-basic/creating-a-blackjack-game-in-visual-basic/ 

As is the guide is not a properly functioning game of Blackjack and will need the following to be corrected:
  1) Instead of creating a new instance of 'Random' every time, create a shared instance of 'Random' so that a random number is correctly generated
  2) Implement correct 'Hit' logic: check if the player has exceeded the maximum of 21, procing the 'Bust' scenario
  3) Implement correct 'Stand' logic: instead of simply comparing the cards, the dealer typically draws cards until they reach 17 or higher
  4) Adjust player winning conditions
