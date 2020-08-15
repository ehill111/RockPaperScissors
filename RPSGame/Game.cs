using System;
using System.Collections.Generic;
using System.Linq;
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
        public Players player1;//Brett
        public Players player2;//Brett


        int setScore;
        int gameScore;
        string playerType;
        Players EricTheHuman;
        Players CruncherTheComputer;

        /*public Game(int NumberOfRounds)
        {
            gameScore = NumberOfRounds;
            //So, I only need "this." for parameters I pass?
            playerOne = new Players();
            playerOne.point++;
        }*/

        //Constructor
        public Game()
        {
            player1 = new Human();//Brett

            //EricTheHuman = new Players();
            //CruncherTheComputer = new Players();
            
        }


        //Methods do something

        public void Welcome()
        {
            Console.WriteLine("Welcome!");
        }

        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules:");
        }

        public void DeterminePlayer2()//Brett
        {
            Console.WriteLine("Do you want 1 player game or 2 player game?");//Brett
            string response = Console.ReadLine();//Brett
            if ()
            {
                player2 = new Human();
            }
            else
            {
                player2 = new Computer();
            }

        }

      

        public void RunGame()//Brett
        {
            //INTRO SECTION
            //Welcome message
            //Display rules
            //Choose game mode: human vs human or human vs computer
            //Optional game variable: player name, number of rounds, etc. These may include set-up things that aren't actually part of the game.


            //ROUNDS OF GAMEPLAY (use a loop, probably while loop)
            //display gesture options if human
            //player1 makes gesture choice
            //display gesture optionsl if human
            //player2 makes gesture choice
            //compare the player's gestures
            //winner gets a point
            //point must be saved
            //move on to next round (if no one yas won yet)


            //Endgame
            //Display the winner
            //Ask if user wants to play again.






        }







    }
}
