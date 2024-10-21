using System.Collections;

namespace exercise4;

public class SoccerTeam : IEnumerable
{
    // Fields
    private string? teamName;
    private Gender teamGender;
    private int ageLimit;
    private List<SoccerPlayer> soccerPlayers;
    private const int MIN_AGE = 5;
    public const int NO_AGE_LIMIT = Int32.MaxValue;

    // Properties
    public string? TeamName
    {
        get
        {
            return teamName;
        }
        set
        {
            teamName = value;
        }
    }

    public Gender TeamGender
    {
        get
        {
            return teamGender;
        }
        set
        {
            teamGender = value;
        }
    }

    public int AgeLimit
    {
        get
        {
            return ageLimit;
        }
        set
        {
            if (value >= MIN_AGE)
            {
                ageLimit = value;
            }
            else
            {
                throw new ArgumentException($"Error: Age limit for a team must be at least {MIN_AGE}");
            }
        }
    }

    // Constructor
    public SoccerTeam(string teamName, Gender teamGender, int ageLimit)
    {
        TeamName = teamName;
        TeamGender = teamGender;
        AgeLimit = ageLimit;
        soccerPlayers = new List<SoccerPlayer>();
    }
    
    // Method
    public IEnumerator GetEnumerator()
    {
        foreach (SoccerPlayer player in soccerPlayers)
        {
            yield return player;
        }
    }

    public void AddPlayer(SoccerPlayer newPlayer)
    {
        if (soccerPlayers.Any(p => p.Name == newPlayer.Name))
        {
            throw new ArgumentException($"Error: Player named '{newPlayer}' is already in the team.");
        }
        else
        {
            soccerPlayers.Add(newPlayer);
        }
    }

    // Indexer
    public SoccerPlayer this[string playerName]
    {
        get
        {
            foreach (SoccerPlayer player in soccerPlayers)
            {
                if (player.Name != null && player.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase))
                {
                    return player;
                }
            }

            throw new ArgumentException($"Error: Player named {playerName} is not found.");
        }
    }
}
