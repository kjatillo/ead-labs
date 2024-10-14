namespace lab2;

public class Line : Shape
{
    // Fields
    private Vertex vertex1;
    private Vertex vertex2;

    // Properties
    public int X1
    {
        get
        {
            return vertex1.X;
        }
        set
        {
            vertex1.X = value;
        }
    }

    public int X2
    {
        get
        {
            return vertex2.X;
        }
        set
        {
            vertex2.X = value;
        }
    }

    public int Y1
    {
        get
        {
            return vertex1.Y;
        }
        set
        {
            vertex1.Y = value;
        }
    }

    public int Y2
    {
        get
        {
            return vertex2.Y;
        }
        set
        {
           vertex2.Y = value;
        }
    }

    // Constructor
    public Line(int x1, int y1, int x2, int y2, ShapeColour shapeColour) : base(shapeColour)
    {
        vertex1 = new Vertex(x1, y1);
        vertex2 = new Vertex(x2, y2);
    }

    // Methods
    public override string ToString()
    {
        return $"The line from ({X1}, {Y2}) to ({X2}, {Y2}) has a colour of {Colour}";
    }

    public override void Translate(Vertex value)
    {
        vertex1.X += value.X;
        vertex1.Y += value.Y;
        vertex2.X += value.X;
        vertex2.Y += value.Y;
    }
}
