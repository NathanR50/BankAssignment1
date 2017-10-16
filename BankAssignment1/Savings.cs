using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssignment1
{
    class Savings : Account
    {
        private double minBalance;


        public double MinBalance
        {
            get { return this.minBalance; }
        }

        public override double Interest()
        {
            return base.Interest() * +balance;
        }


        //constructors
        public Savings(double balance) : base()
        {
            this.minBalance = 0;
            this.balance = balance;
            accountType = "Savings Account";

        }
    }
}
