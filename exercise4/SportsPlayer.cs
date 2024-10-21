namespace exercise4;

public abstract class SportsPlayer
{
    // Properties
    public string? Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }

    // Constructor
    public SportsPlayer(string name, int age, Gender gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    // Method
    public override string ToString()
    {
        return $"Player Name: {Name} | Age: {Age} | Gender: {Gender}";
    }
}
