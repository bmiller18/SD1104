using System;
using System.Collections.Generic;

namespace Lesson12ArraySortCompare
{
    class Program
    {
        public static bool SearchCondition(int i)
        {
            return i == 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! from Lesson12");

            //Sorting an Array
            int[] numbers = { 8, 9, 2, 20, 1, 5, 3, 10, 7, 6 };
            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Reversing the Order of the Array
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //Sorting a List
            List<char> myList = new List<char>();
            myList.Add('c');
            myList.Add('a');
            myList.Add('d');
            myList.Add('b');
            myList.Add('e');

            myList.Sort();
            foreach (char item in myList)
            {
             Console.WriteLine(item);
            }

            //Reversing the List
            myList.Reverse();
            foreach (char item in myList)
            {
                Console.WriteLine(item);
            }

            DateTime[] dates = { Convert.ToDateTime("7/21/2020"), Convert.ToDateTime("7/20/2020"), Convert.ToDateTime("8/8/2020") };
            Array.Sort(dates);
            foreach (DateTime date in dates)
            {
                Console.WriteLine(date.ToString());
            }

            //Creating complex data
            SuperHero superman = new SuperHero("Superman", 10, 9, 5);
            SuperHero batman = new SuperHero("Batman", 3, 2, 7);
            SuperHero flash = new SuperHero("Flash", 6, 10, 4);

            SuperHero[] allSuperHeros = { superman, batman, flash };

            //We need a Comparer to Sort our Super Heros
            SuperSpeedComparer speedComparer = new SuperSpeedComparer();
            Array.Sort(allSuperHeros, speedComparer);
            Console.WriteLine("\n List of Fastest Heros");

            foreach (SuperHero hero in allSuperHeros)
            {
                Console.WriteLine(hero.name);
            }

            SuperHero fastest = allSuperHeros.GetValue(0) as SuperHero;
            Console.WriteLine("\n The FASTEST Super Hero is " + fastest.name);

            //We need a Comparer to Sort our Super Heros
            SuperStrengthComparer strengthComparer = new SuperStrengthComparer();
            Array.Sort(allSuperHeros, strengthComparer);
            Console.WriteLine("\n List of Strongest Heros");

            foreach (SuperHero hero in allSuperHeros)
            {
                Console.WriteLine(hero.name);
            }

            SuperHero strongest = allSuperHeros.GetValue(0) as SuperHero;
            Console.WriteLine("\n The STRONGEST Super Heo is " + strongest.name);

            //int searchResult = Array.Find(numbers, SearchConditions);
            int searchResult = Array.Find(numbers, search => search == 10);

            //this code will find the value returned by SearchCondition method
            int results = Array.Find(numbers, SearchCondition);

            //another example
            int results2 = Array.Find(numbers, search => search < 5);//return first value less than 5
            int results3 = Array.Find(numbers, search => search > 6 & search < 8); //return first value greater than 6 and less than 8
            Console.WriteLine("SEARCH RESULTS: " + searchResult + " " + results + " " + results2 + " " + results3);

            object myVaule = 20;
            Array.Sort(numbers);
            int bsearchResult = Array.BinarySearch(numbers, myVaule);
            Console.WriteLine("SEARCH RESULTS " + searchResult);
            Console.WriteLine("BINARY SEARCH RESULTS " + bsearchResult);


        }
    }
}
