namespace lab4;

public class Calculator
{
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Error! Cannot divide by 0.");
        } else
        {
            return a / b;
        }
    }
}
