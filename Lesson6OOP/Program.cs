using System;

namespace Lesson6OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal animal1 = new Animal(4, 0, "Cat", "Snowball", true);
            Animal animal2 = new Animal(8, 0, "Spider", "Friendly the Spider", false);
            Animal animal3 = new Animal(2, 2, "Monkey", "Bobo", false);

            animal1.ShowDetails();
            animal3.ShowDetails();
            animal1.SendToObedienceSchool();
            animal1.ShowDetails();
            animal3.SendToObedienceSchool();
            animal3.ShowDetails();

            animal2.Evolve(2, 12);
            animal2.ShowDetails();
        }
    }
}
