using System;
namespace BankingSystem
{
    class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // Virtual method to display account type
        public virtual void DisplayAccountType()
        {
            Console.WriteLine("General Bank Account");
        }

        // Method to display account details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: Rs.{Balance:F2}");
        }
    }

    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        // Override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("Savings Account");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }

   class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit;

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        // Override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("Checking Account");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Withdrawal Limit: Rs.{WithdrawalLimit:F2}");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        public DateTime MaturityDate;

        public FixedDepositAccount(int accountNumber, double balance, DateTime maturityDate)
            : base(accountNumber, balance)
        {
            MaturityDate = maturityDate;
        }

        // Override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("Fixed Deposit Account");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Maturity Date: {MaturityDate.ToShortDateString()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(11, 5000.0, 3.5);
            Console.WriteLine("Savings Account Details:");
            savingsAccount.DisplayAccountType();
            savingsAccount.DisplayDetails();
            Console.WriteLine();
            CheckingAccount checkingAccount = new CheckingAccount(14, 2000.0, 1000.0);
            Console.WriteLine("Checking Account Details:");
            checkingAccount.DisplayAccountType();
            checkingAccount.DisplayDetails();
            Console.WriteLine();

            FixedDepositAccount fixedDepositAccount = new FixedDepositAccount(13, 10000.0, DateTime.Now.AddYears(1));
            Console.WriteLine("Fixed Deposit Account Details:");
            fixedDepositAccount.DisplayAccountType();
            fixedDepositAccount.DisplayDetails();
        }
    }
}
