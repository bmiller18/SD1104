using System;
using System.Collections.Generic;

namespace lab5_2EnumTaskList
{
    class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_2!");

            List<string> taskList = new List<string>();

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
