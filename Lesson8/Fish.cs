using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
    class Fish : Animal
    {
        private int gills = 2;

        public Fish(bool isDangerous)
        {
            name = "Freddy the Fish";
            numOfArms = 0;
            numOfLegs = 0;
            isFurry = false;
            this.isDangerous = isDangerous;
        }

        public override void Breath()
        {
            Console.WriteLine("The fish breathes through it's gills!");
        }

        public override int Sell()
        {
            Console.WriteLine("I'll sell my fish for $5 dollars.");
            return 5;
        }
    }
}
