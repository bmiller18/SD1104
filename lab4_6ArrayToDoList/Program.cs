using System;

namespace lab4_6ArrayToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab4_6!");

            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            string[] tasks = new string[days.Length];

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("Enter a new task for " + days[i]);
                string task = days[i] + " : " + Console.ReadLine();
                tasks[i] = task;
            }

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
