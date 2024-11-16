using System.Globalization;

namespace Enacapsulation
{
    class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative");
                }
            }
        }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Deposited : {amount.ToString("C", CultureInfo.GetCultureInfo("en-US"))}. New Balance: {Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.New Balance: {Balance.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");

            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(500);

            account.Deposit(150);
            account.Withdraw(100);
            account.Withdraw(700);

        }
    }  
}