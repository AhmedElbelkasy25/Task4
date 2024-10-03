using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class TrustAccount : SavingsAccount
    {
        private int count;
        private DateTime date;
        private int year;
        
        public TrustAccount( string name="no name" , double balance=0.0 , double interestRate = 0.0)
            :base(name , balance , interestRate) 
            { 
                count = 0; 
                date = DateTime.Now;
                year = DateTime.Now.Year +1;
            }
            
        
        public override bool Deposit(double amount)
        {
            if (amount >= 5000)
                amount += 50;
            return base.Deposit(amount);
        }

        public override bool Withdraw(double amount)
        {
            if (date.Year >= year)
            {
                count = 0;
                year++;
            }
            
            if (count > 2 || amount > 0.2*Balance)
            { return false;}
            else {
                count++;
                return base.Withdraw(amount);
            
            
            }
        }
    }
}
