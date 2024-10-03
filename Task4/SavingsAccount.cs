using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class SavingsAccount: Account
    {
        public double InterestRate { get; set; }


        public SavingsAccount(string name= "no name" , double balance = 0 ,  double interestRate =0 )
           : base(name , balance)
        {
            this.InterestRate = interestRate;
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+InterestRate);
        }
    }
}
