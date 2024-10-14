namespace lab2;

public class Program
{
    static void Main()
    {
        Shape[] shapes =
        {
            new Line(3, 3, 4, 4, ShapeColour.Blue),
            new Circle(2, 3, 12, ShapeColour.Red)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Before translation: {shape}");
            shape.Translate(new Vertex(10, 10));
            Console.WriteLine($"After translation: {shape}");
        }
    }
}
