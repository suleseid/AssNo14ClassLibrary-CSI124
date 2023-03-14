using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace MyLibrary
{
    public static class DiceRoll
    {
        // To make this an extension method, includ the word this
        public static int RollTheDie(this string numberOfSides)
        {
            int maxSide = 0;
            bool isNumber = int.TryParse(numberOfSides, out maxSide);
          
            if (isNumber)
            {
                maxSide += 1;
                int minSide = 1;

                Random rand = new Random();
                return rand.Next(minSide, maxSide);
            }
            else
            {
                //throw 
                throw new DiceRollException("This was not a proper dice roll");
            }
        }
    }  
}
