using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

//Welcome to the game.
//Name of Game: Paper, Rock, Scissors, Lizard, Spock
//Purpose of Game: Use gestures to win points. 
//Who plays the game?
// * Humans and computers.
//How game is played.
// * Players simultaneously selects a gesture.
// * Some gestures are worth more than others.
// * Player with the most valuable gesture wins that round and a point.
// * Each player's points are saved.
// * First player to win two rounds wins that set.
// * First player to win two sets wins the game.
//Winner is declared champion!

namespace RPSGame
{   //Member variables have/has a/an...
    class Game
    {
        public Players player1;
        public Players player2;
        string player1GestureSelection;
        string player2GestureSelection;
        string Rock;
        string Paper;
        string Scissors;
        string Lizard;
        string Spock;
        int player1Score = 0;
        int player2Score = 0;
        int player1SetScore = 0;
        int player2SetScore = 0;
        int player1GameScore = 0;
        int player2GameScore = 0;
       
           
        //Constructor
        public Game()
        {
            player1 = new Human();
            
        }

        //Methods do something

        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to the Paper, Rock, Scissors, Lizard, Spock game!");
        }

        public void DiscussObjective()
        {
            Console.WriteLine("The object of the game is to select a gesture that is superior to the gesture chosen by your opponent. The names of the gestures are here: 1. Rock, 2. Paper, 3. Scissors, 4. Lizard, and 5. Spock.");
        }

        public void DisplayRules()
        {
            Console.WriteLine(" Here are the relative values of each gesture: a. Rock crushes Scissors, b. Scissors cuts Paper, c. Paper covers Rock, d.Rock crushes Lizard, e. Lizard poisons Spock, f. Spock smashes Scissors, g. Scissors decapitates Lizard, h. Lizard eats Paper, i. Paper disproves Spock, j. Spock vaporizes Rock. The game will be played as follows: 1. Each player will select a gesture. 2. The player with the superior gesture wins a point. 3. If both players select the same gesture, no point is awarded and the players replay. 4. The player who wins two of three points wins the set. 5. The player who wins two of three rounds wins the game! Press any key when you are ready.");
            Console.ReadLine();
            Console.WriteLine("Let's play!");
        }

        public void DeterminePlayer2()
        {
            Console.WriteLine("Select your opponent. Type 1 for a computer or type 2 for a human.");
            Console.ReadLine();
            string response = Console.ReadLine();
            if (response == "1")
            {
                player2 = new Human();
                Console.WriteLine("Your opponent is human.");
                Console.ReadLine();
            }
            else
            {
                player2 = new Computer();
                Console.WriteLine("Your opponent is a computer.");
                Console.ReadLine();
            }

        }

        public void PromptForGesture()
        {
            Console.WriteLine("You may now select a gesture. Enter one of the numbers: (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock.");
        }

        public void player1.SelectGesture()//I don't know how to call a method from another class.
        {
            string player1Selection;
            
        }

        public void player2.SelectGesture()//I don't know how to call a method from another class.
        {
            string player2GestureSelection;
        }


        //Below are all the possible selections the players may make and the subsequent awarding of points.
        public void AwardPoints1()
            //Player1

            //Rock
        {
            if (player1GestureSelection == "Rock" || (player2GestureSelection == Scissors && player2GestureSelection == Lizard))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }

            //Paper
            if (player1GestureSelection == "Paper" || (player2GestureSelection == Rock && player2GestureSelection == Spock))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }

            //Scissors
            if (player1GestureSelection == "Scissors" || (player2GestureSelection == Paper && player2GestureSelection == Lizard))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }

            //Lizard
            if (player1GestureSelection == "Lizard" || (player2GestureSelection == Spock && player2GestureSelection == Paper))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }

            //Spock
            if (player1GestureSelection == "Spock" || (player2GestureSelection == Scissors && player2GestureSelection == Rock))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }
        }

        public void AwardPoints2()
        {   //Player2

            //Rock
            if (player2GestureSelection == "Rock" || (player1GestureSelection == Scissors && player1GestureSelection == Lizard))
            {
                player2Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player2 + "! You won the point!");
                Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
            }
            else
            {
                player1Score = player1Score + 1;
            }

            //Paper
            if (player2GestureSelection == "Paper" || (player1GestureSelection == Rock && player1GestureSelection == Spock))
            {
                player2Score = player2Score + 1;
                Console.WriteLine("Congratulations " + player2 + "! You won the point!");
                Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
            }

            //Scissors
            if (player2GestureSelection == "Scissors" || (player1GestureSelection == Paper && player1GestureSelection == Lizard))
            {
                player2Score = player2Score + 1;
                Console.WriteLine("Congratulations " + player2 + "! You won the point!");
                Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
            }
            else
            {
                player1Score = player1Score + 1;
            }

            //Lizard
            if (player2GestureSelection == "Lizard" || (player1GestureSelection == Spock && player1GestureSelection == Paper))
            {
                player2Score = player2Score + 1;
                Console.WriteLine("Congratulations " + player2 + "! You won the point!");
                Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
            }
            else
            {
                player1Score = player1Score + 1;
            }

            //Spock
            if (player2GestureSelection == "Spock" || (player1GestureSelection == Scissors && player1GestureSelection == Rock))
            {
                player2Score = player2Score + 1;
                Console.WriteLine("Congratulations " + player2 + "! You won the point!");
                Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
            }
            else
            {
                player1Score = player1Score + 1;
            }
        }

        //Tie Hand
        public void AwardNoPoints()
        //Both players
        {
            if (player1GestureSelection == "Rock" && player2GestureSelection == "Rock")
            {
                Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
                //Use SelectGesture. 
            }
            else if (player1GestureSelection == "Paper" && player2GestureSelection == "Paper")
            {
                Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
                //Use SelectGesture. 
            }
            else if (player1GestureSelection == "Scissors" && player2GestureSelection == "Scissors")
            {
                Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
                //Use SelectGesture. 
            }
            else if (player1GestureSelection == "Lizard" && player2GestureSelection == "Lizard")
            {
                Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
                //Use SelectGesture. 
            }
            else if (player1GestureSelection == "Spock" && player2GestureSelection == "Spock")
            {
                Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
                //Use SelectGesture. 
            }

        }

        public void CaptureSetPoints()
        {
            if (player1Score == 2)
            {
                player1SetScore = player1SetScore + 1;
                player1GameScore = player1GameScore + 1;
                Console.WriteLine("Congratulations! You've won the set. Two more sets and you win the whole game!");
                player1Score = 0;//This is to reset player1Score and player2Score to 0 so the next set begins at 0.
            }
            else if (player2Score == 2)
            {
                player2SetScore = player2SetScore + 1;
                player2GameScore = player2GameScore + 1;
                Console.WriteLine("Congratulations! You've won the set. Two more sets and you win the whole game!");
                player2Score = 0;//This is to reset player1Score and player2Score to 0 so the next set begins at 0.
            }

        }

        public void DisplayWinnerOfGame()
        {
            if (player1GameScore == 3)
            {
                Console.WriteLine("Congratulations" + player1 + "! You've won the whole game!");
                
            }
            else if (player2GameScore == 3)
            {
                Console.WriteLine("Congratulations" + player2 + "! You've won the whole game!");
            }
        }

       

         
    }







}

