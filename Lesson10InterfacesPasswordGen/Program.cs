using System;

namespace Lesson10InterfacesPasswordGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson 10!");

            PepperoniPizza pepperoni = new PepperoniPizza();
            pepperoni.Prepare();

            CheesePizza cheese = new CheesePizza();
            cheese.Prepare();

            PasswordGenerator passwordGen = new PasswordGenerator();
            string password = passwordGen.CreatePassword();
            Console.WriteLine("New Password is : " + password);
        }
    }
}
