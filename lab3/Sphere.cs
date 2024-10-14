namespace lab3;

public class Sphere : IHasVolume
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
    public Sphere() : this(0) { }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    // Methods
    public double CalculateVolume()
    {
        return Math.PI * radius * radius * radius;
    }

    public override string ToString()
    {
        return $"{base.ToString()}. It has a radius of: {radius.ToString()}";
    }
}
