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

            Console.WriteLine("Please enter the number that represents your choice of gesture. Rock = 1, Paper = 2, Scissors = 3, Lizard = 4, and Spock = 5.");
            List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            int index = int.Parse(Console.ReadLine()) - 1;
            gesture = gestures[index];
            return gestures[index];
            int result = index;
           
            Console.ReadLine();
            Console.WriteLine(gesture[index]); 

           
        }
    }
}
