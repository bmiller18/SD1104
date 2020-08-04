using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lesson 8!");

            Dog myDog = new Dog("Fido", 4, 0, false, true, "Dog Bone");
            myDog.Bark();
            myDog.Eat();
            myDog.Sleep();


            DancingCat someCrazyCat = new DancingCat("Electric Slide", "Melo the Dancing Cat");
            someCrazyCat.Eat();
            someCrazyCat.Meow();
            someCrazyCat.AnnoyYou();
            someCrazyCat.Dance();

            Fish bigFish = new Fish(false);
            bigFish.Breath();

            int money = 0;
            money += bigFish.Sell();
            money += myDog.Sell();
            money += someCrazyCat.Sell();
            Console.WriteLine("After selling my pets, I have " + money);

            Customer customer1 = new Customer("Marcus", "Tadwell");
            customer1.membership.ChangeMembership(MemberShip.Level.Preimum);
            customer1.membership.plan.ChangeRenewal(Plan.Renewal.Annual);
        }
    }
}
