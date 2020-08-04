using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityTVStar
{
    class HouseHunter : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuying;
        public int numOfBedrooms;
        public int numOfBathrooms;

        public HouseHunter(string jobTitle, int currentAnnualIncome, int whenBuying, int numOfBedrooms, int numOfBathrooms, string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip, string phoneNum, string email) : base (firstName, lastName, dateOfBirth, address, city, state, zip, phoneNum, email)
        {
            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentAnnualIncome;
            this.whenBuying = whenBuying;
            this.numOfBedrooms = numOfBedrooms;
            this.numOfBathrooms = numOfBathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters.");
        }
    }
}
