using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab8_5RealityTVStar
{
    class Application
    {
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phoneNum;
        public string email;
        public bool appSubmitted;
        public bool appAccepted;

        public Application(string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip, string phoneNum, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNum = phoneNum;
            this.email = email;
            appSubmitted = false;
            appAccepted = false;
        }

        public void Submit()
        {
            appSubmitted = true;
            Console.WriteLine("Application has been submitted.");
        }

        public virtual void Accept()
        {
            appAccepted = true;
            Console.WriteLine("Application Accepted.");
        }
    }
}
