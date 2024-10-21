namespace exercise3;

public class Program
{
    static void Main()
    {
        // Create music tracks
        MusicFile track1 = new MusicFile("track1.mp3", "Snooze", "SZA", Genre.RnB);
        MusicFile track2 = new MusicFile("track2.mp3", "euphoria", "Kendrick Lamar", Genre.Rap);
        MusicFile track3 = new MusicFile("track3.mp3", "Overrated", "Blxst", Genre.Rap);
        MusicFile track4 = new MusicFile("track4.mp3", "Sure Thing", "Miguel", Genre.RnB);
        MusicFile track5 = new MusicFile("track5.mp3", "Immaculate Taste", "Engelwood");

        // Create playlist and add tracks
        Playlist myPlaylist = new Playlist("Mixed Genre");
        myPlaylist.AddTrack(track1);
        myPlaylist.AddTrack(track2);
        myPlaylist.AddTrack(track3);
        myPlaylist.AddTrack(track4);
        myPlaylist.AddTrack(track5);

        // Attempt to add duplicate track - throws exception error
        //MusicFile track6 = new MusicFile("track4.mp3", "Be The One", "Khalid", Genre.Pop);
        //myPlaylist.AddTrack(track6);

        // Test iterator
        Console.WriteLine($"*** {myPlaylist.Name} Playlist - All Tracks ***");
        foreach (MusicFile track in myPlaylist.TrackList)
        {
            Console.WriteLine(track);
        }

        Console.WriteLine();

        // Test indexer
        Console.WriteLine($"*** {myPlaylist.Name} Playlist - Rap Tracks ***");
        foreach (MusicFile track in myPlaylist[Genre.Rap])
        {
            Console.WriteLine(track);
        }

        Console.WriteLine();

        Console.WriteLine($"*** {myPlaylist.Name} Playlist - RnB Tracks ***");
        foreach (MusicFile track in myPlaylist[Genre.RnB])
        {
            Console.WriteLine(track);
        }
    }
}
