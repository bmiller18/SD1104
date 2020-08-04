using System;
using System.Text;

namespace Lesson9Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson 9!");

            Polymorphism polymorphism = new Polymorphism();

            Console.WriteLine($"Add Overload 1 { polymorphism.Add(10, 10)}");

            Console.WriteLine($"Add Overload 2 { polymorphism.Add("The", "Cat")}");

            Console.WriteLine($"Add Overload 3 { polymorphism.Add(10, 10, 10)}");


            PolyChild polyChild = new PolyChild();

            if (polyChild is Polymorphism)
            {
                Console.WriteLine("The polyChild class is also a simple class.");
            }

            FileWriter fileWriter = new FileWriter();
            fileWriter.ExampleWriteFile();

            UserAccount user = new UserAccount("coolUser1", "secretPass12");
            user.Login("coolUser1", "forgot password");
            user.Login("coolUser1", "Password??");
            user.Login("coolUser1", "secretPass12");
            user.GetUserInfo();

            string string1 = "My first piece of text.";
            string string2 = "My second piece of text.";

            string moreText = string1 + string2;
            Console.WriteLine(moreText);

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append(string1);
            paragraph.Append(string2);
            paragraph.Append("Adding yet more text. ");

            Console.WriteLine(paragraph.ToString());

            StringBuilder htmlText = new StringBuilder();
            string bodyOpen = "<body>";
            string bodyClose = "</body>";
            string pOpen = "<p>";
            string pClose = "</p>";
            Console.WriteLine("Enter some text you want to put on your web page.");
            string dynamicHTML = Console.ReadLine();

            htmlText.Append(bodyOpen);
            htmlText.Append(pOpen);
            htmlText.Append(dynamicHTML);
            htmlText.Append(pClose);
            htmlText.Append(bodyClose);
            fileWriter.CreateHTML(htmlText);
        }
    }
}
