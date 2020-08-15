using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Human : Players
    {
        
         public Human()
        {
            this.name = name;
        }

        public override void SelectGesture()
        {
            List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            int index = int.Parse(Console.ReadLine());
            gesture = gestures[index];

            Console.WriteLine("Please enter the number that represents your choice of gesture. Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, and Spock = 4.");
            string response = Console.ReadLine();
            Console.WriteLine();

           
        }
    }
}
