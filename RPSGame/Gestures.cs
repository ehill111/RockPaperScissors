﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Gestures
    {
        int rock;
        int paper;
        int scissors;
        int lizard;
        int spock;
        List<string> gestures;

        public void BuildGestureList()
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }







    }
}
