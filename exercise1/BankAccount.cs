namespace exercise1;

public abstract class BankAccount
{
    // Fields
    private string? accountNumber;
    private decimal balance;

    // Properties
    public string? AccountNumber 
    { 
        get
        {
            return accountNumber;
        }
    }

    public decimal Balance
    {
        get
        {
            return balance;
        }
        set
        {
            balance = value;
        }
    }

    // Constructor
    public BankAccount(string accountNumber)
    {
        this.accountNumber = accountNumber;
        this.balance = 0;
    }

    // Methods
    public abstract void MakeDeposit(decimal depositAmount);
    public abstract void MakeWithdrawal(decimal withdrawalAmount);
}
