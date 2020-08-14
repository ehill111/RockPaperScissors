using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Human : Players
    {
        
        public Human(string name)
        {
            this.name = name;
        }

        public override void SelectGesture()
        {
            List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

            Console.WriteLine("");

            int index = int.Parse(Console.ReadLine());
            gesture = gestures[index];
        }
    }
}
