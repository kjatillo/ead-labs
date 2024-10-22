namespace exercise5;

public class RadioPlayerApp
{
    // Fields
    private List<RadioStation> radioStations;
    private List<RadioStation> favouriteStations;

    // Properties
    public List<RadioStation> RadioStations
    {
        get
        {
            return radioStations;
        }
    }

    public List<RadioStation> FavouriteStations
    {
        get
        {
            return favouriteStations;
        }
    }

    // Constructor
    public RadioPlayerApp()
    {
        radioStations = new List<RadioStation>();
        favouriteStations = new List<RadioStation>();
    }

    // Indexer
    public IEnumerable<RadioStation> this[Genre genre]
    {
        get
        {
            var stationByGenre = radioStations
                                    .Where(s => s.Genre == genre)
                                    .OrderBy(s  => s.Frequency)
                                    .ToList();
            return stationByGenre;
        }
    }

    // Method
    public void Like(string stationName)
    {
        if (favouriteStations.Any(s => s.Name == stationName))
        {
            throw new ArgumentException("Error: Station already in the favourite list.");
        }
        else
        {
            var findStation = radioStations.Where(s => s.Name == stationName).FirstOrDefault();
            if (findStation != null)
            {
                favouriteStations.Add(findStation);
            }
            else
            {
                throw new ArgumentException("Error: Station not found!");
            }
        }
    }

    public void Unlike(string stationName)
    {
        var findStation = favouriteStations.Where(s => s.Name == stationName).FirstOrDefault();

        if (findStation != null)
        {
            favouriteStations.Remove(findStation);
        }
    }

    public void Add(RadioStation station)
    {
        if (radioStations.Any(s => s.Name == station.Name))
        {
            throw new ArgumentException("Error: Station already in the stations list.");
        }
        else
        {
            radioStations.Add(station);
        }
    }
}
