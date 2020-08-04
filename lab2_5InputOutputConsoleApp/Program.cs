using System;

namespace lab2_5InputOutputConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int intFirstNumber = 0;
            int intSecondNumber = 0;
            int intThirdNumber = 0;
            int intResult = 0;
            double dblResult = 0;

            Console.WriteLine("Enter your First Number: ");
            intFirstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Second Number: ");
            intSecondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Third Number: ");
            intThirdNumber = Convert.ToInt32(Console.ReadLine());

            intResult = intFirstNumber + intSecondNumber;
            Console.WriteLine($"{intFirstNumber} plus {intSecondNumber} is {intResult}");

            intResult = intFirstNumber - intSecondNumber;
            Console.WriteLine($"{intFirstNumber} minus {intSecondNumber} is {intResult}");

            intResult = intFirstNumber * intSecondNumber;
            Console.WriteLine($"{intFirstNumber} multiplied {intSecondNumber} is {intResult}");

            dblResult = intFirstNumber / Convert.ToDouble(intSecondNumber);
            Console.WriteLine($"{intFirstNumber} divided by {intSecondNumber} is {dblResult}");

            string personsName = string.Empty;
            Console.WriteLine("Please enter your name: ");
            personsName = Console.ReadLine();
            Console.WriteLine($"Hello, {personsName}");

            intResult = intFirstNumber * intSecondNumber * intThirdNumber;
            Console.WriteLine($"{intFirstNumber} multiplied by {intSecondNumber} multiplied by {intThirdNumber} is {intResult}");

            int intAge = 0;
            Console.WriteLine("Please enter your age: ");
            intAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"You look younger than {intAge}.");
        }
    }
}
