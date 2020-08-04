using System;

namespace Lab5_6IfStatement
{
    class Program
    {
        public struct Customer
        {
            public string firstName;
            public string lastName;
            public int age;
            public bool membershipStatus;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_6!");

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.firstName = "Sarah";
            customer1.lastName = "James";
            customer1.age = 18;
            customer1.membershipStatus = false;

            customer2.firstName = "Joel";
            customer2.lastName = "Miller";
            customer2.age = 56;
            customer2.membershipStatus = false;

            customer3.firstName = "Jack";
            customer3.lastName = "Jackson";
            customer3.age = 38;
            customer3.membershipStatus = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if(allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is underage and cannot place order.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is 21 or older and can place order.");
                }
                if (allCustomers[i].membershipStatus == true)
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].firstName + " " + allCustomers[i].lastName + " is not a premium member.");
                }
            }
        }
    }
}
