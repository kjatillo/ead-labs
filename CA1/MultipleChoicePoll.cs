namespace CA1;

public class MultipleChoicePoll
{
    // Fields
    private string? title;
    private List<Option> options = new List<Option>();

    // Properties
    public string? Title
    {
        get
        {
            return title;
        }
        init
        {
            if (value != null)
            {
                if (value.Length > 30)
                {
                    throw new ArgumentException("Title can only be up to 30 characters only.");
                }

                if (value.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)) || value.Length > 30)
                {
                    throw new ArgumentException("Title can only contain letters, numbers, or spaces.");
                }
                else
                {
                    title = value;
                }
            }
        }
    }

    public DateTime DueDate { get; init; }
    public int OptionCount
    {
        get
        {
            return options.Count;
        }
    }

    // Methods
    public void AddOption(Option newOption)
    {
        options.Add(newOption);
    }

    public void CastVote(int optionNumber, int numberOfVotes)
    {
        GetOption(optionNumber).NumberOfVotes += numberOfVotes;
        UpdateVotePercentage();
    }

    public Option GetOption(int optionNumber)
    {
        return options[optionNumber];
    }

    public void UpdateVotePercentage()
    {
        int totalNumberOfVotes = 0;

        foreach (Option option in options)
        {
            totalNumberOfVotes += option.NumberOfVotes;
        }

        foreach (Option option in options)
        {
            option.VotePercentage = (double) option.NumberOfVotes / totalNumberOfVotes * 100;
        }
    }
}
