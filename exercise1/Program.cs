namespace exercise1;

public class Program
{
    static void Main()
    {
        // Configure console output encoding to display € symbol
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Create instance of current account
        CurrentAccount myCurrentAccount = new CurrentAccount(1000000.0m, "KEN123");

        // Make transactions
        myCurrentAccount.MakeDeposit(1000000.0m);
        myCurrentAccount.MakeDeposit(112321.0m);
        myCurrentAccount.MakeWithdrawal(23232.0m);
        //myCurrentAccount.MakeWithdrawal(5000000000.0m);  // Throws exception

        Console.WriteLine(myCurrentAccount);
    }
}
