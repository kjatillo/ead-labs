namespace exercise4;

public class SoccerPlayer : SportsPlayer
{
    // Property
    public Position Position { get; set; }

    // Constructor
    public SoccerPlayer(string name, int age, Gender gender, Position position) 
        : base(name, age, gender)
    {
        Position = position;
    }

    public SoccerPlayer() : this(string.Empty, 0, Gender.Male, Position.Defender) { }

    // Method
    public override string ToString()
    {
        return $"Player Name: {Name} | Age: {Age} | Gender: {Gender} | Position: {Position}";
    }
}
