using System;

namespace OOPDemo
{
    internal class BankAccount
    {
        private int accountNumber;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Amount Deposited: " + amount);
                Console.WriteLine("Current Balance = " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn: " + amount);
                Console.WriteLine("Current Balance = " + Balance);
            }
        }

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.AccountNumber = 101;
            account.Deposit(5000);
            account.Withdraw(2000);

            Console.WriteLine("Final Balance = " + account.Balance);
        }
    }
}
