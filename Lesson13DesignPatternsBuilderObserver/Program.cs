using System;

namespace Lesson13DesignPatternsBuilderObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson13!");

            TheBuilder DellBuilder = new TheBuilder("Dell", "Inspiron");
            DellBuilder.AddFirstOption("black", 15);
            DellBuilder.AddSecondOption(8);
            DellBuilder.AddThirdOptions(256);

            Laptop dell1 = DellBuilder.GetLaptop();

            DellBuilder.AddFirstOption("silver", 14);
            DellBuilder.AddSecondOption(16);
            DellBuilder.AddThirdOptions(500);

            Laptop dell2 = DellBuilder.GetLaptop();

            //Observer
            ClassA source = new ClassA();
            FirstObserver observer1 = new FirstObserver(source);
            SecondObserver observer2 = new SecondObserver(source);
            source.ChangeMe(5);
            source.ChangeMe(90);
            source.ChangeMe(200);
            source.ChangeMe(1);
        }
    }
}
