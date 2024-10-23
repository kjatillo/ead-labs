namespace CA1;

public class Option
{
    // Properties
    public TextOption TextOption { get; init; }
    public int NumberOfVotes { get; set; }
    public double VotePercentage { get; set; }

    // Method
    public override string ToString()
    {
        return $"Option: {TextOption} | Number of Votes: {NumberOfVotes} | Vote Percentage: {VotePercentage:F2}%";
    }
}
