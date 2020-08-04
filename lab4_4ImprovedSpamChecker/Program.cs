using System;

namespace lab4_4ImprovedSpamChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] blackList =
            {
                "buy", "viagra", "XXX", "free money",
                "lifetime offer", "send money", "bank account",
                "nigeria", "online pharmacy", "h8te", "meet girls"
            };

            string message = Console.ReadLine();
            bool isSpam = false;
            message = message.ToLower();
            for (int i = 0; i < blackList.Length; i++)
            {
                if (message.Contains(blackList[i]))
                {
                    isSpam = true;
                }
            }

            if(isSpam == true)
            {
                Console.WriteLine("The message contained spam.");
            }
            else
            {
                Console.WriteLine("This message is Ok.");
            }
        }
    }
}
