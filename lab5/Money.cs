namespace lab5;

public struct Money
{
    // Rates 20-10-2024
    private const decimal EURO_TO_DOLLAR = 1.09m;
    private const decimal EURO_TO_YEN = 162.62m;
    private const decimal DOLLAR_TO_EURO = 0.92m;
    private const decimal DOLLAR_TO_YEN = 149.52m;
    private const decimal YEN_TO_EURO = 0.0061m;
    private const decimal YEN_TO_DOLLAR = 0.0067m;

    // Properties
    public decimal Amount { get; set; }
    public Currency Currency { get; set; }

    // Constructor
    public Money(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    // Methods
    public decimal Convert(Currency newCurrency)
    {
        if (Currency == newCurrency)
        {
            return Amount;
        }
        else
        {
            if (Currency == Currency.Euro)
            {
                if (newCurrency == Currency.Dollar)
                {
                    return Amount * EURO_TO_DOLLAR;
                }
                else if (newCurrency == Currency.Yen)
                {
                    return Amount * EURO_TO_YEN;
                }
                else
                {
                    throw new ArgumentException("Invalid currency specified.");
                }
            }
            else if (Currency == Currency.Dollar)
            {
                if (newCurrency == Currency.Euro)
                {
                    return Amount * DOLLAR_TO_EURO;
                }
                else if (newCurrency == Currency.Yen)
                {
                    return Amount * DOLLAR_TO_YEN;
                }
                else
                {
                    throw new ArgumentException("Invalid currency specified.");
                }
            }
            else if (Currency == Currency.Yen)
            {
                if (newCurrency == Currency.Euro)
                {
                    return Amount * YEN_TO_EURO;
                }
                else if (newCurrency == Currency.Dollar)
                {
                    return Amount * YEN_TO_DOLLAR;
                }
                else
                {
                    throw new ArgumentException("Invalid currency specified");
                }
            }
            else
            {
                throw new ArgumentException("Invalid currency specified.");
            }
        }
    }

    public Money AddMoney(Money otherMoney)
    {
        Currency newCurrency = this.Currency;
        decimal newAmount;

        if (this.Currency == otherMoney.Currency)
        {
            newAmount = this.Amount + otherMoney.Amount;
            return new Money(newAmount, newCurrency);
        }
        else
        {
            newAmount = this.Amount + otherMoney.Convert(this.Currency);
            return new Money(newAmount, newCurrency);
        }
    }
}
