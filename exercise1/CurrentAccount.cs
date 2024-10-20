using System.Text;

namespace exercise1;

public class CurrentAccount : BankAccount
{
    // Fields
    private decimal overdraftLimit;
    private List<AccountTransaction> transactions = new();

    // Properties
    public decimal OverdraftLimit
    {
        get
        {
            return overdraftLimit;
        }
    }

    // Constructor
    public CurrentAccount(decimal overdraftLimit, string accountNumber)
        : base(accountNumber)
    { 
        this.overdraftLimit = overdraftLimit;
    }

    // Methods
    public override void MakeDeposit(decimal depositAmount)
    {
        this.Balance += depositAmount;
        this.transactions
            .Add(new AccountTransaction(
                TransactionType.Deposit, depositAmount));
    }

    public override void MakeWithdrawal(decimal withdrawalAmount)
    {
        if (withdrawalAmount < (this.Balance + overdraftLimit))
        {
            this.Balance -= withdrawalAmount;
            this.transactions
                .Add(new AccountTransaction(
                    TransactionType.Withdrawal, withdrawalAmount));
        }
        else
        {
            throw new ApplicationException(
                "Transaction Cancelled: Insufficient Funds.");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append($"[Current Account] Account Number: {AccountNumber} | " +
            $"Current Balance: {CurrencyFormatter.Format(Balance)}");
        sb.Append("\n-- Transaction History --\n");

        foreach (AccountTransaction transaction in transactions)
        {
            sb.Append($"{transaction}\n");
        }

        return sb.ToString();
    }
}
