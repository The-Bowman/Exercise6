using System;

namespace Exercise6
{
    class Driver
    {
        static void Main(string[] args)
        {
            Dice dice1 = new Dice(1);
            Dice dice2 = new Dice(10000);

            int rollCounter = 0;

            Console.WriteLine("Initial: " + dice1.getNumSides());
            Console.WriteLine("Initial dice2: " + dice2.getNumSides());

            dice1.setSides(20);
            Console.WriteLine("After assignment: " + dice1.getNumSides());

            do
            {
                dice1.roll();
                dice2.roll();
                rollCounter++;
                Console.WriteLine("Roll: " + dice1.getRoll() + " " + dice2.getRoll());
            } while (dice1.getRoll() != 1 || dice2.getRoll() != 1);

            Console.WriteLine("SNAKE EYES: " + dice1.getRoll() + " : " + dice2.getRoll());
            Console.WriteLine("Number of rolls to get snake eyes: " + rollCounter);
            
        }
    }
}
