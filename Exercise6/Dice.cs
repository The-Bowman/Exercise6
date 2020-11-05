using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    class Dice
    {
        private int numSides;   //number of sides on the dice, ranging from 4 to 20
        private int sideRolled; //the side facing up on the dice

        public Dice(int i)
        {
            setSides(i);
        }

        //sets the number of sides of a dice between 4 and 20
        public int setSides(int i)
        {
            if (i < 4 )
            {
                return numSides= 4;
            } else if (i > 20)
            {
                return numSides = 20;
            } else
            {
                return numSides = i;
            }
        }

        public int roll()
        {
            Random rand = new Random();
            return sideRolled =  rand.Next(1, this.getNumSides() + 1);
           
        }

        public int getNumSides()
        {
            return this.numSides;
        }

        public int getRoll()
        {
            return this.sideRolled;
        }
    }
}
