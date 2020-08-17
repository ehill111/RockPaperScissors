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

        //Constructor
        public override string SelectGesture()
        {

            Console.WriteLine("Please enter the number that represents your choice of gesture. Rock = 0, Paper = 1, Scissors = 2, Lizard = 3, and Spock = 4.");
            List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            int index = int.Parse(Console.ReadLine());
            gesture = gestures[index];
            return gestures[index];
            int result = index;
           
            Console.ReadLine();
            Console.WriteLine(gesture[index]); 

           
        }
    }
}
