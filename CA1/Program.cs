﻿namespace CA1;

public class Program
{
    static void Main()
    {
        // Create multiple choice poll
        MultipleChoicePoll myPoll = new MultipleChoicePoll()
        { 
            Title = "Favourite Food by Country", 
            DueDate = DateTime.Now.AddMinutes(5) 
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

        // Display output
        Console.WriteLine($"<--- {myPoll.Title} --->");
        for (int i = 0; i < myPoll.OptionCount; ++i)
        {
            Console.WriteLine(myPoll.GetOption(i));
        }
    }
}
