using System;


namespace FunctionsDemo
{
    internal class BankAccountEncapsulation
    {
        private double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        static void Main(string[] args)
        {
            BankAccountEncapsulation account = new BankAccountEncapsulation();

            account.Deposit(1000);
            account.Withdraw(300);
            Console.WriteLine("Current Balance = " + account.GetBalance());
        }
    }
}
