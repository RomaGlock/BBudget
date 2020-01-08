using System;
using System.Collections.Generic;
using System.Text;

namespace BBudget
{
    public class BbAccount
    {
        public decimal Balance { get; private set; }
        public string Name { get;  }

        public BbAccount(string accountName, decimal initalBalance)
        {
            Balance = initalBalance;
            Name = accountName;
        }

        public override string ToString()
        {
            return $"Account {Name} ({Balance})";
        }

        public void TransactionOccuredHandler(BbAccount src, BbAccount dst, decimal value)
        {
            if (src != this && dst != this)
            {
                return;
            }
            else if (src == this)
            {
                this.Balance -= value;
                Console.WriteLine($"{Name}: -{value}");
            }
            else
            {
                Balance += value;
                Console.WriteLine($"{Name}: +{value}");
            }
        }
    }
}
