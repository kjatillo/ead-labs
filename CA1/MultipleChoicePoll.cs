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
        if (options.Any(option => option.TextOption == newOption.TextOption))
        {
            throw new ArgumentException("An identical option already exists.");
        }

        options.Add(newOption);
    }

    public void CastVote(int optionNumber, int numberOfVotes)
    {
        if (DateTime.Now > DueDate)
        {
            throw new InvalidOperationException("Cannot cast vote after the due date.");
        }

        GetOption(optionNumber).NumberOfVotes += numberOfVotes;
        UpdateVotePercentage();
    }

    public Option GetOption(int optionNumber)
    {
        if (optionNumber < 0 || optionNumber >= options.Count)
        {
            throw new ArgumentOutOfRangeException("Option number is range is out of bounds.");
        }

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
