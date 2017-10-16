using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment1
{
    abstract class Client
    {

        // fields
        public string firstName;
        public string lastName;
        private double interestRate;

        //properties
        public double InterestRate
        { get { return this.interestRate; } }

        public string FirstName
        { get { return this.firstName; } }

        public string LastName
        { get { return this.lastName; } }



        //constructor
        public virtual string ClientInfo()
        {
            string clientinfo = ("Account Holder: " + firstName + " " + lastName);
            return clientinfo;
        }
    }
}
