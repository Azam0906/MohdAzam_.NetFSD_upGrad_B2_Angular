using System;

namespace BankWithdrawalSystem
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Error: Withdrawal amount exceeds available balance");
            }

            balance -= amount;
            Console.WriteLine("Withdrawal successful. Remaining Balance: " + balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Balance: ");
                double balance = double.Parse(Console.ReadLine());
                BankAccount account = new BankAccount(balance);
                Console.Write("Enter Withdraw Amount: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input");
            }
            finally
            {
                Console.WriteLine("Transaction completed");
            }
        }
    }
}