namespace exercise5;

internal class Program
{
    static void Main()
    {
        // Create radio stations
        RadioStation rteRadio1 = new() { Name = "RTE Radio 1", Genre = Genre.General, Frequency = 89};
        RadioStation rte2fm = new() { Name = "RTE 2FM", Genre = Genre.Music, Frequency = 90 };
        RadioStation newstalk = new() { Name = "Newstalk", Genre = Genre.News, Frequency = 106 };
        RadioStation fm104 = new() { Name = "FM 104", Genre = Genre.Music, Frequency = 104.4 };
        RadioStation fm98 = new() { Name = "98 FM", Genre = Genre.Music, Frequency = 98 };

        // Create a radio player
        RadioPlayerApp myRadioPlayer = new();

        // Add stations to radio player app
        myRadioPlayer.Add(rteRadio1);
        myRadioPlayer.Add(rte2fm);
        myRadioPlayer.Add(newstalk);
        myRadioPlayer.Add(fm104);
        myRadioPlayer.Add(fm98);

        // Favourite a station
        myRadioPlayer.Like("RTE 2FM");
        myRadioPlayer.Like("Newstalk");
        myRadioPlayer.Unlike("rte 2fm");

        // Display all stations
        Console.WriteLine("-- All Stations --");
        foreach (RadioStation station in myRadioPlayer.RadioStations)
        {
            Console.WriteLine(station);
        }

        // Display favourite stations
        Console.WriteLine();
        Console.WriteLine("-- Favourite Stations --");
        foreach (RadioStation station in myRadioPlayer.FavouriteStations)
        {
            Console.WriteLine(station);
        }

        // Diplay music stations
        Console.WriteLine();
        Console.WriteLine("-- Music Stations --");
        foreach (RadioStation station in myRadioPlayer[Genre.Music])
        {
            Console.WriteLine(station);
        }
    }
}
