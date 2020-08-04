using System;

namespace Lab7_4DatingWebsite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab7_4!");

            DatingProfile datingProfile1 = new DatingProfile("John", "Smith", 28, "Male");
            datingProfile1.WriteBio("Looking for a serious relationship.");

            DatingProfile datingProfile2 = new DatingProfile("Alexis", "James", 30, "Female");
            datingProfile2.WriteBio("Interested in finding someone to travel the world with.");

            datingProfile1.SendMessage("Hello Alexis, I was looking at your profile.", "Want to meet for lunch tomorrow?", datingProfile2);
            datingProfile2.ReadMessage();
        }
    }
}
