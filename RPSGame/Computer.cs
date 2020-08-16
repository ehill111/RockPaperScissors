using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Computer : Players
    {
        public Computer()
        {
            this.name = name;
            
        }
 
            //Constructor
        public override void SelectGesture()
        {
            //Random random = new Random();
            //List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            //int index = random.Next(gestures.Count);
            //gesture = gestures[index];
            //Console.WriteLine("The debugger reached here.");
            //Console.WriteLine(gestures[index]);
            //Console.ReadLine();

            var random = new Random();

            var list = new List<string> { "Paper", "Rock", "Scissors", "Lizard", "Spock" };
            int index = random.Next(list.Count);

            Console.WriteLine(list[index]);
            Console.ReadLine();

        //Methods (do something)


        }
    }
}
