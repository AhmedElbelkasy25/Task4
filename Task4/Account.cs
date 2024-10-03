using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    

    public class Account
    {
        
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            Name = name;
            Balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                Balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public static Account operator + (Account a, Account b)
        {
            Account c = new Account();
            c.Name = a.Name;
            c.Balance = a.Balance + b.Balance;
            return c;
        }
        public override string ToString()
        {
            return $"Account: {Name}";
        }

    }
}
