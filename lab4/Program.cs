namespace lab4;

public class Program
{
    public static void Main()
    {
        // Exercise 1 - Calculator
        try
        {
            Console.Write("Enter first operand: ");
            double operand1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter second operand: ");
            double operand2 = Double.Parse(Console.ReadLine());

            Console.WriteLine(Calculator.Divide(operand1, operand2));
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (OverflowException of)
        {
            Console.WriteLine(of.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

        // Exercise 2 - Module CA Results
        try
        {
            ModuleCAResults results = new ModuleCAResults()
            {
                ModuleName = "softdev",
                Credit = 5,
                StudentName = "John Smith"
            };

            results[1] = 25;
            results[2] = 35;
            results[3] = 45;
            results[1] = 55;
            results[3] = 80;
            results[4] = 90;

            Console.WriteLine(results);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
