using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_task
{
    internal struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
            }
        }
        public Account(int id, string holder, decimal bal)
        {
            accountId = id;
            accountHolder = holder;
            balance = bal >= 0 ? bal : 0;
        }
        public void Display()
        {
            Console.WriteLine($"ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}");
        }
    }
}
