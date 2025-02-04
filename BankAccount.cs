using System;
class BankAccount
{
    private static string bankName = "Punjab National Bank";
    private static int totalAccounts = 0;

    public readonly int AccountNumber;
    public string AccountHolderName;
    public double Balance;

    // Static property to get or update the bank name
    public static string BankName
    {
        get { return bankName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                bankName = value;
                Console.WriteLine($"Bank name updated to: {bankName}");
            }
            else
            {
                Console.WriteLine("Bank name cannot be empty.");
            }
        }
    }

    public BankAccount(string AccountHolderName, int AccountNumber, double initialBalance)
    {
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;
        this.Balance = initialBalance;
        totalAccounts++;
    }

    // Static method to get total number of accounts
    public static void GetTotalAccounts()
    {
        Console.WriteLine($"Total Bank Accounts: {totalAccounts}");
    }

    // Method to display account details using 'is' operator
    public void DisplayAccountDetails()
    {
        if (this is BankAccount)
        {
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
        }
    }
}

class Program
{
    static void Main()
    {
   
        BankAccount account1 = new BankAccount("Krishav", 1301, 34000);
        BankAccount account2 = new BankAccount("Atharv", 1402, 90000);
        BankAccount account3 = new BankAccount("Reeva", 1212, 56000);


        Console.WriteLine("Before Changing Bank Name:");
        account1.DisplayAccountDetails();
        Console.WriteLine();
        account2.DisplayAccountDetails();
		Console.WriteLine();
        account3.DisplayAccountDetails();

        Console.WriteLine("\nChanging Bank Name...\n");
       
   
        BankAccount.BankName = "SBI Bank";

        Console.WriteLine("\nAfter Changing Bank Name:");
        account1.DisplayAccountDetails();
        Console.WriteLine();
        account2.DisplayAccountDetails();
		Console.WriteLine();
        account3.DisplayAccountDetails();
       
        Console.WriteLine();

        BankAccount.GetTotalAccounts();
    }
}
