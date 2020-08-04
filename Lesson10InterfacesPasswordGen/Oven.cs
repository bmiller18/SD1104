using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10InterfacesPasswordGen
{
    class Oven
    {
        public Oven()
        {

        }

        public void Bake(IPizza pizza)
        {
            Console.WriteLine("I baked a " + pizza.GetType() + " pizza.");
        }
    }
}
