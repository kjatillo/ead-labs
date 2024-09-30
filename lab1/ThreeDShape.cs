namespace lab1;

public abstract class ThreeDShape
{
    // Field
    private string? type;

    // Property
    public string? Type
    {
        get
        {
            return type;
        }
    }

    // Constructor
    public ThreeDShape(string type)
    {
        this.type = type;
    }

    // Methods
    public abstract double CalculateVolume();

    public override string ToString()
    {
        return $"This is a shape of type '{type}'";
    }
}

public class Sphere : ThreeDShape
{
    // Field
    private double radius;

    // Property
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (radius >= 0)
            {
                radius = value;
            }
            else
            {
                throw new ArgumentException("Radius value must be positive!");
            }
        }
    }

    // Constructors
    public Sphere(double radius) : base("Sphere")
    {
        Radius = radius;
    }

    public Sphere() : this(0) { }

    // Methods
    public override double CalculateVolume()
    {
        return Math.PI * radius * radius * radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()}. It has a radius of: {radius.ToString()}";
    }
}
