namespace exercise5;

public class RadioStation : IStreamable
{
    // Field
    private double frequency;

    // Properties
    public string? Name { get; set; }
    public Genre Genre { get; set; }
    public double Frequency
    {
        get
        {
            return frequency;
        }
        set
        {
            if (value > 87.5 && value < 108)
            {
                frequency = value;
            }
            else
            {
                throw new ArgumentException("Error: Frequency out of range!");
            }
        }
    }

    public void Pause()
    {
        Console.WriteLine($"Pausing Station: {Name}");
    }

    public void Play()
    {
        Console.WriteLine($"Playing Staion: {Name}");
    }

    public override string ToString()
    {
        return $"Station Name: {Name} | Genre: {Genre} | Frequency: {Frequency}";
    }
}
