namespace exercise1;

public class AccountTransaction
{
    // Fields
    private TransactionType type;
    private decimal amount;

    // Constructors
    public AccountTransaction(TransactionType type, decimal amount)
    {
        this.type = type;
        this.amount = amount;
    }

    // Methods
    public override string ToString()
    {
        return $"Type: {type} | Amount: {CurrencyFormatter.Format(amount)}";
    }
}
