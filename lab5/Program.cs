namespace lab5;

public class Program
{
    static void Main()
    {
        Money m1 = new Money(23.12m, Currency.Dollar);
        Money m2 = new Money(2323.22m, Currency.Euro);

        Money m3 = m1.AddMoney(m2);

        Console.WriteLine($"Money 1: {m1.Amount} {m1.Currency}");
        Console.WriteLine($"Money 2: {m2.Amount} {m2.Currency}");
        Console.WriteLine($"Money 3: {m3.Amount} {m3.Currency}");
    }
}
