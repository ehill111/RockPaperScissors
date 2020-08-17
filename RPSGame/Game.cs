using System;
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
        //int player1SetScore = 0;
        //int player2SetScore = 0;
        //int player1GameScore = 0;
        //int player2GameScore = 0;
       
           
        //Constructor
        public Game()
        {
            player1 = new Human();
            
        }

        //Methods do something

        public void WelcomePlayer()
        {
            Console.WriteLine("Welcome to the Paper, Rock, Scissors, Lizard, Spock game! Press any key to continue.");
            Console.ReadLine();
        }

        public void DiscussObjective()
        {
            Console.WriteLine("The object of the game is to select a gesture that is superior to the gesture chosen by your opponent. The names of the gestures are here: 0. Rock, 1. Paper, 2. Scissors, 3. Lizard, and 4. Spock. Press enter.");
            Console.ReadLine();
        }

        public void DisplayRules()
        {
            Console.WriteLine(" Here are the relative values of each gesture: a. Rock crushes Scissors, b. Scissors cuts Paper, c. Paper covers Rock, d.Rock crushes Lizard, e. Lizard poisons Spock, f. Spock smashes Scissors, g. Scissors decapitates Lizard, h. Lizard eats Paper, i. Paper disproves Spock, j. Spock vaporizes Rock. The game will be played as follows: 1. Each player will select a gesture. 2. The player with the superior gesture wins a point. 3. If both players select the same gesture, no point is awarded and the players replay. 4. The player who wins two of three points wins the game! Press any key when you are ready.");
            Console.ReadLine();
            Console.WriteLine("Let's play! Press enter.");
            Console.ReadLine();
        }

        public void DeterminePlayer2()
        {
            Console.WriteLine("Select your opponent. Type 1 for a human or type 2 for a Computer.");
            Console.ReadLine();
           string response = Console.ReadLine();
            if (response == "1")
            {
                player2 = new Human();
                Console.WriteLine("Your opponent is human. Press enter.");
                Console.ReadLine();
            }
            else if(response == "2")
            {
                player2 = new Computer();
                Console.WriteLine("Your opponent is a computer. Press enter.");
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
            //if...
            
            Console.WriteLine("You may now select a gesture: (0) Rock, (1) Paper, (2) Scissors, (3) Lizard, or (4) Spock. Enter a number and press enter.");
            string result = Console.ReadLine();//Nothing captures the selection!
            result = player1GestureSelection;

            //The second player should also select a gesture here.
        }

        //public void player1.SelectGesture()//I don't know how to call a method from another class.
        //{
        //    string player1Selection;
            
        //}

        //public void player2.SelectGesture()//I don't know how to call a method from another class.
        //{
        //    string player2GestureSelection;
        //}


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
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Paper
            else if (player1GestureSelection == "Paper" && (player2GestureSelection == "Rock" || player2GestureSelection =="Spock"))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Scissors
            else if (player1GestureSelection == "Scissors" && (player2GestureSelection == "Paper" || player2GestureSelection == "Lizard"))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Lizard
            else if (player1GestureSelection == "Lizard" && (player2GestureSelection == "Spock" || player2GestureSelection == "Paper"))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            //Spock
            else if (player1GestureSelection == "Spock" && (player2GestureSelection == "Scissors" || player2GestureSelection == "Rock"))
            {
                player1Score = player1Score + 1;
                Console.WriteLine("Congratulations " + player1 + "! You won the point!");
                Console.WriteLine("Sorry, " + player2 + ". You didn't win this time.");
            }
            else
            {
                player2Score = player2Score + 1;
                Console.WriteLine("Congratulations " + player1.name + "! You won the point!");
                Console.WriteLine("Sorry, " + player2.name + ". You didn't win this time.");
            }
        }

        //public void AwardPoints2()
        //{   //Player2

        //    //"Rock"
        //    if (player2GestureSelection == "Rock" && (player1GestureSelection == "Scissors") || (player1GestureSelection == Lizard))
        //    {
        //        player2Score = player1Score + 1;
        //        Console.WriteLine("Congratulations " + player2 + "! You won the point!");
        //        Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
        //    }
        //    else
        //    {
        //        player1Score = player1Score + 1;
        //    }

        //    //Paper
        //    if (player2GestureSelection == "Paper" && (player1GestureSelection == Rock) && (player1GestureSelection == Spock))
        //    {
        //        player2Score = player2Score + 1;
        //        Console.WriteLine("Congratulations " + player2 + "! You won the point!");
        //        Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
        //    }
        //    else
        //    {
        //        player2Score = player2Score + 1;
        //    }

        //    //Scissors
        //    if (player2GestureSelection == "Scissors" && (player1GestureSelection == Paper) || (player1GestureSelection == Lizard))
        //    {
        //        player2Score = player2Score + 1;
        //        Console.WriteLine("Congratulations " + player2 + "! You won the point!");
        //        Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
        //    }
        //    else
        //    {
        //        player1Score = player1Score + 1;
        //    }

        //    //Lizard
        //    if (player2GestureSelection == "Lizard" && (player1GestureSelection == Spock) || (player1GestureSelection == Paper))
        //    {
        //        player2Score = player2Score + 1;
        //        Console.WriteLine("Congratulations " + player2 + "! You won the point!");
        //        Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
        //    }
        //    else
        //    {
        //        player1Score = player1Score + 1;
        //    }

        //    //Spock
        //    if (player2GestureSelection == "Spock" && (player1GestureSelection == Scissors) || (player1GestureSelection == Rock))
        //    {
        //        player2Score = player2Score + 1;
        //        Console.WriteLine("Congratulations " + player2 + "! You won the point!");
        //        Console.WriteLine("Sorry, " + player1 + ". You didn't win this time.");
        //    }
        //    else
        //    {
        //        player1Score = player1Score + 1;
        //    }
        //}

        ////Tie Hand
        //public void AwardNoPoints()
        ////Both players
        //{
        //    if (player1GestureSelection == "Rock" && player2GestureSelection == "Rock")
        //    {
        //        Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
        //        //Use SelectGesture. 
        //    }
        //    else if (player1GestureSelection == "Paper" && player2GestureSelection == "Paper")
        //    {
        //        Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
        //        //Use SelectGesture. 
        //    }
        //    else if (player1GestureSelection == "Scissors" && player2GestureSelection == "Scissors")
        //    {
        //        Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
        //        //Use SelectGesture. 
        //    }
        //    else if (player1GestureSelection == "Lizard" && player2GestureSelection == "Lizard")
        //    {
        //        Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
        //        //Use SelectGesture. 
        //    }
        //    else if (player1GestureSelection == "Spock" && player2GestureSelection == "Spock")
        //    {
        //        Console.WriteLine("This hand is a tie. You both chose the same gesture. Please make another selection.");
        //        //Use SelectGesture. 
        //    }

        //}

        //public void CaptureSetPoints()
        //{
        //    if (player1Score == 2)
        //    {
        //        player1SetScore = player1SetScore + 1;
        //        player1GameScore = player1GameScore + 1;
        //        Console.WriteLine("Congratulations! You've won the set. Two more sets and you win the whole game!");
        //        player1Score = 0;//This is to reset player1Score and player2Score to 0 so the next set begins at 0.
        //    }
        //    else if (player2Score == 2)
        //    {
        //        player2SetScore = player2SetScore + 1;
        //        player2GameScore = player2GameScore + 1;
        //        Console.WriteLine("Congratulations! You've won the set. Two more sets and you win the whole game!");
        //        player2Score = 0;//This is to reset player1Score and player2Score to 0 so the next set begins at 0.
        //    }

        //}

        public void DisplayWinnerOfGame()
        {
            if (player1Score == 3)
            {
                Console.WriteLine("Congratulations" + player1.name + "! You've won the whole game!");
                
            }
            else if (player2Score == 3)
            {
                Console.WriteLine("Congratulations" + player2 + "! You've won the whole game!");
            }
        }

        public void EndGame()
        {
            player1Score = 0;
            player2Score = 0;
            bool RunGame = true;
            while (RunGame == true)
            {
                if ((player1Score == 3) || (player2Score == 3))
                {
                    RunGame = false;
                }
                player1Score++;
                player2Score++;
            }
        }

        public void RunGame()
        {
            WelcomePlayer();

            DiscussObjective();

            DisplayRules();
            //Choose game mode - human vs human or human vs computer, computer vs computer?
            DeterminePlayer2();

            player1GestureSelection = player1.SelectGesture();
            player2GestureSelection = player2.SelectGesture();
            //Console.Clear();
            Console.WriteLine("Player 1 picked: " + player1GestureSelection);
            Console.WriteLine("Player 2 picked: " + player2GestureSelection);

            AwardPoints();

            //AwardPoints2();

           // AwardNoPoints();

            //CaptureSetPoints();

            player1Score = 0;
            player2Score = 0;
            bool RunGame = true;
            while (RunGame == true)
            {
                if ((player1Score == 3) || (player2Score == 3))
                {
                    RunGame = false;
                }
                player1Score++;
                player2Score++;
            }

            DisplayWinnerOfGame();

            EndGame();
        }


    }







}

