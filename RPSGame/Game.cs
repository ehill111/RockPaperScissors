﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RPSGame
{   //Member variables have/has a/an...
    class Game
    {
        public Players player1;
        public Players player2;
        string player1GestureSelection;
        string player2GestureSelection;

        int player1Score = 0;
        int player2Score = 0;
        
        //Constructor
        public Game()
        {
            player1 = new Human();
            
        }

        //Methods do something

        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to the Paper, Rock, Scissors, Lizard, Spock game! Press Enter to continue.");
            Console.ReadLine();
        }

        public void DiscussObjective()
        {
            Console.WriteLine("The object of the game is to select a gesture that is superior to the gesture chosen by your opponent. The names of the gestures are here: 0. Rock, 1. Paper, 2. Scissors, 3. Lizard, and 4. Spock. Press Enter.");
            Console.ReadLine();
        }

        public void DisplayRules()
        {
            Console.WriteLine(" Here are the relative values of each gesture: a. Rock crushes Scissors, b. Scissors cuts Paper, c. Paper covers Rock, d.Rock crushes Lizard, e. Lizard poisons Spock, f. Spock smashes Scissors, g. Scissors decapitates Lizard, h. Lizard eats Paper, i. Paper disproves Spock, j. Spock vaporizes Rock. The game will be played as follows: 1. Each player will select a gesture. 2. The player with the superior gesture wins a point. 3. If both players select the same gesture, no point is awarded and the players replay. 4. The player who wins two of three points wins the game! Press Enter key when you are ready.");
            Console.ReadLine();
        }

        public void DeterminePlayer2()
        {
            Console.WriteLine("Select your opponent. Type 1 for a human or type 2 for a Computer and press Enter..");
            Console.ReadLine();
            string response = Console.ReadLine();
            if (response == "1")
            {
                player2 = new Human();
                Console.WriteLine("Your opponent is human. Press Enter.");
                Console.ReadLine();
            }
            else if (response == "2")
            {
                player2 = new Computer();
                Console.WriteLine("Your opponent is a computer. Press Enter.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid input. You get a computer now.");
                player2 = new Computer();
            }

        }

        public void PromptForGesture()
        {
            player1GestureSelection = player1.SelectGesture();
            player2GestureSelection = player2.SelectGesture();
            //Console.Clear();
            Console.WriteLine("Player 1 picked: " + player1GestureSelection);
            Console.WriteLine("Player 2 picked: " + player2GestureSelection);
        }
        //Below are all the possible selections the players may make and the subsequent awarding of points.
        public void AwardPoints()
        //Player1

        //Rock
        {
            if (player1GestureSelection == player2GestureSelection)
            {
                Console.WriteLine("Tie");
            }
            else if (player1GestureSelection == "Rock" && (player2GestureSelection == "Scissors" || player2GestureSelection == "Lizard"))
            {
                player1Score++;
                Console.WriteLine(player1Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Paper
            else if (player1GestureSelection == "Paper" && (player2GestureSelection == "Rock" || player2GestureSelection == "Spock"))
            {
                 player1Score++;
                Console.WriteLine(player1Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Scissors
            else if (player1GestureSelection == "Scissors" && (player2GestureSelection == "Paper" || player2GestureSelection == "Lizard"))
            {
                player1Score++;
                Console.WriteLine(player1Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Lizard
            else if (player1GestureSelection == "Lizard" && (player2GestureSelection == "Spock" || player2GestureSelection == "Paper"))
            {
                
                player1Score++;
                Console.WriteLine(player1Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Spock
            else if (player1GestureSelection == "Spock" && (player2GestureSelection == "Scissors" || player2GestureSelection == "Rock"))
            {
                
                player1Score++;
                Console.WriteLine(player1Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                
                player2Score++;
                Console.WriteLine(player2Score);
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2.name + ". You didn't win this time.");
            }

            Console.WriteLine("Player 1 score is : " + player1Score);
            Console.WriteLine("Player 2 score is : " + player2Score);

        }

        
       
        public void DisplayWinnerOfGame()
        {
            if (player1Score == 2)
            {
                Console.WriteLine("Congratulations" + player1 + "! You've won the whole game!");

            }
            else if (player2Score == 2)
            {
                Console.WriteLine("Congratulations" + player2 + "! You've won the whole game!");
            }
            Console.WriteLine("Thank you for playing my game!");
            Console.ReadLine();
        }
        public void RunRounds()
        {
            while (player1Score < 2 && player2Score < 2)
            {
                PromptForGesture();

                AwardPoints();
            }
        }
       public void RunGame()
        {
            WelcomePlayer();

            DiscussObjective();

            DisplayRules();
            //Choose game mode - human vs human or human vs computer, computer vs computer?
            DeterminePlayer2();

            RunRounds();
           
           

            // AwardNoPoints();

            DisplayWinnerOfGame();

            
        }
    }

}









