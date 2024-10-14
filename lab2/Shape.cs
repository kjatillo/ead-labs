namespace lab2;

public enum ShapeColour
{
    Red, Green, Blue
}

public abstract class Shape
{
    // Field
    private ShapeColour colour;

    // Property
    public ShapeColour Colour
    {
        get
        {
            return colour;
        }
        set
        {
            colour = value;
        }
    }

    // Constructor
    public Shape(ShapeColour colour)
    {
        this.colour = colour;
    }

    // Methods
    public override string ToString()
    {
        return $"The colour of the shape is {colour}";
    }

    public abstract void Translate(Vertex value);
}
