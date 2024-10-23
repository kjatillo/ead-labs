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
        return $"- Option: {TextOption,-10} | Number of Votes: {NumberOfVotes,-5} | Vote Percentage: {VotePercentage,6:F2}%";
    }
}
