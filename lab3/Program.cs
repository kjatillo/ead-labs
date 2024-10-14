namespace lab3;

public class Program
{
    static void Main()
    {
        IHasVolume[] shapes =
        {
            new Sphere(),
            new Sphere(12)
        };

        foreach (IHasVolume shape in shapes)
        {
            Console.WriteLine($"{shape} volume: {Math.Round(shape.CalculateVolume(), 2)}");
        }
    }
}
