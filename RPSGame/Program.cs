using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game flamnigo = new Game(80);
            //Players thing = new Players();
            //Players bob = new Computer("Bob");
            //Players frank = new Human("Frank");

            //Players bob = new Computer("Bob");
            //Players frank = new Human("Frank");

            //bob.SelectGesture();
            //frank.SelectGesture();

            Game game = new Game();//Brett
            game.RunGame();//Brett
            Console.WriteLine();
            Console.ReadLine();
            
            /*{
                var random = new Random();

                var list = new List<string> { "Paper", "Rock", "Scissors", "Lizard", "Spock" };
                int index = random.Next(list.Count);

                Console.WriteLine(list[index]);
                Console.ReadLine();
            }*/



        }
    }
}
