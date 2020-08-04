using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityTVStar
{
    class AboveDeck : Application
    {
        public int yearsOfExperience;
        public string nationality;

        public AboveDeck(int yearsOfExperience, string nationality, string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip, string phoneNum, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNum, email)
        {
            this.yearsOfExperience = yearsOfExperience;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck.");
        }
    }
}
