using System;
using System.Threading.Channels;

namespace Lab8_5RealityTVStar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab8-5!");

            HouseHunter hhAccplicant = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland piAcclicant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/19934", "211 Love Rd", "Los Angeles", "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck adAcclicant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Way", "Los Angeles", "California", 90001, "711-333-1234", "captian@gmail.com");

            hhAccplicant.Submit();
            hhAccplicant.Accept();

            piAcclicant.Submit();
            piAcclicant.Accept();

            adAcclicant.Submit();
            adAcclicant.Accept();
        }
    }
}
