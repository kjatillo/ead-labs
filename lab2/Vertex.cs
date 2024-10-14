namespace lab2;

public class Vertex
{
    // Fields
    private int x;
    private int y;

    // Properties
    public int X 
    {
        get
        {
            return x;
        }
        set
        {
            x = value;
        }
    }
    public int Y
    { 
        get
        {
            return y;
        }
        set
        {
            y = value;
        }
    }

    // Constructor
    public Vertex(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
