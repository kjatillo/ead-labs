namespace Bank.BankAccount
{
    public class BankAccount
    {
        // Fields
        private string _accountNumber;
        private decimal _balance;

        // Properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; }

        public BankAccount(string accountNumber, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Balance = 0;
        }

        public abstract MakeDeposit(decimal amount);
        public abstract MakeWithdrawal(decimal amount);
    }

    public class CurrentAccount: BankAccount
    {
        public CurrentAccount
    }
}