namespace lab2;

public class Circle : Shape
{
    // Fields
    private Vertex origin;

    // Properties
    public int Radius { get; set; }
    public int X
    {
        get
        {
            return origin.X;
        }
        set
        {
            origin.X = value;
        }
    }

    public int Y
    {
        get
        {
            return origin.Y;
        }
        set
        {
            origin.Y = value;
        }
    }

    // Constructor
    public Circle(int x, int y, int radius, ShapeColour shapeColour) : base(shapeColour)
    {
        origin = new Vertex(x, y);
        Radius = radius;
    }

    // Methods
    public override string ToString()
    {
        return $"The circle at ({X}, {Y}) has a radius of {Radius}, colour of {Colour}, and area of {Math.Round(this.CalculateArea(), 2)}";
    }

    public override void Translate(Vertex value)
    {
        origin.X += value.X;
        origin.Y += value.Y;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
