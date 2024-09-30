namespace lab1;

public class Program
{
    static void Main(string[] args)
    {
        ThreeDShape[] shapes = { new Sphere(), new Sphere(10) };

        foreach (ThreeDShape shape in shapes)
        {
            Console.WriteLine($"{shape} and volume of: {Math.Round(shape.CalculateVolume(), 2)}");
        }
    }
}
