using System.Globalization;

namespace exercise1;

public static class CurrencyFormatter
{
    private static readonly CultureInfo euroCulture;

    static CurrencyFormatter()
    {
        euroCulture = new CultureInfo("en-IE");
    }

    public static string Format(decimal amount)
    {
        return amount.ToString("C2", euroCulture);
    }
}
