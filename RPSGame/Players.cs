using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{   //Member variables have/has a/an...
    //Why didn't Brett use public?
    abstract class Players
    {

        public int point;
        public string name;
        public string gesture;
        
        
     //Constructors initialize values upon instantiation. 
        public Players()
        {
            point = 0;
            
        }

        //Methods do something.
        public virtual string SelectGesture()
        {
            // human way 
            return "";
        }
        

        
            //displaying choices
            //getting user input
            
            
        


    }
}
