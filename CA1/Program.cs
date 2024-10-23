namespace CA1;

public class Program
{
    static void Main()
    {
        // Create multiple choice poll
        MultipleChoicePoll myPoll = new MultipleChoicePoll()
        { 
            Title = "Favourite Food by Country", 
            DueDate = DateTime.Now.AddDays(5)
            // DueDate = new DateTime(2024, 10, 22)  // Throws an error, cannot vote after due date
        };

        // Add options to the poll
        myPoll.AddOption(new Option() { TextOption = TextOption.French, NumberOfVotes = 0 });
        myPoll.AddOption(new Option() { TextOption = TextOption.Thai, NumberOfVotes = 0 });
        myPoll.AddOption(new Option() { TextOption = TextOption.Italian, NumberOfVotes = 0 });
        myPoll.AddOption(new Option() { TextOption = TextOption.Chinese, NumberOfVotes = 0 });

        // Cast votes
        myPoll.CastVote(0, 223);
        myPoll.CastVote(1, 123);
        myPoll.CastVote(2, 444);
        myPoll.CastVote(3, 324);
        // myPoll.CastVote(4, 324);  // Throws an error, no option added at element position 4

        // Display output
        Console.WriteLine($"[ {myPoll.Title} ]");
        for (int i = 0; i < myPoll.OptionCount; ++i)
        {
            Console.WriteLine(myPoll.GetOption(i));
        }
    }
}
