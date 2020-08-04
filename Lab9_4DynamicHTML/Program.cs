using System;

namespace Lab9_4DynamicHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab9-4!");

            Console.WriteLine("Hello World from Lab9-4!");

            HtmlPageBuilder htmlPageBuilder = new HtmlPageBuilder();
            htmlPageBuilder.CollectThenCreateHTML();
        }
    }
}
