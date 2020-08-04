using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5RealityTVStar
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfBoyOrGirlFriend;
        public int yearsDating;

        public ParadiseIsland(string gender, string nameOfBoyOrGirlFriend, int yearsDating, string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip, string phoneNum, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNum, email)
        {
            this.gender = gender;
            this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island.");
        }
    }
}
