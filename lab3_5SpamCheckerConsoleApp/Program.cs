using System;

namespace lab3_5SpamCheckerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Updated and works but needs refactoring
            // - More words in Blacklist
            // - Resolve Uppercase/Lowercase issue with words
            // - Use external db or flatfile that is easy to update without having to update the code
            // Added 06.23.2020
            Console.WriteLine("Hello World!");

            string blackListWord = "boom";
            bool isSpam = false;

            string message = Console.ReadLine();

            if (message.Contains(blackListWord))
            {
                isSpam = true;
                Console.WriteLine("This message is spam!");
            }
            else
            {
                isSpam = false;
                Console.WriteLine("This message is not spam.");
            }
        }
    }
}
