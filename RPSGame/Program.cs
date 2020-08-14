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
           
            
                //Random random = new Random();
                //List<string> list = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

                //int index = random.Next(list.Count);

                //Console.WriteLine(list[index]);
                //Console.ReadLine(); 

                Players bob = new Computer("Bob");
                Players frank = new Human("Frank");

                bob.SelectGesture();
                frank.SelectGesture();
            

        }
    }
}
