using System.Collections;

namespace exercise3;

public class Playlist : IEnumerable
{
    // Fields
    private List<MusicFile> trackList;

    // Property
    public string? Name { get; set; }
    public List<MusicFile> TrackList
    {
        get
        {
            return trackList;
        }
    }

    // Constructor
    public Playlist(string playlistName)
    {
        Name = playlistName;
        trackList = new List<MusicFile>();
    }

    // Methods
    public void AddTrack(MusicFile track)
    {
        if (trackList.Any(t => t.Title == track.Title && t.Artist == track.Artist))
        {
            throw new ArgumentException($"The track titled '{track.Title}' by " +
                $"'{track.Artist}' is already in the track list.");
        }
        else
        {
            trackList.Add(track);
        }
    }

    public IEnumerator GetEnumerator()
    {
        foreach (MusicFile mf in trackList)
        {
            yield return mf;
        }
    }

    // Indexer
    public IEnumerable<MusicFile> this[Genre genre]
    {
        get
        {
            var tracksByGenre = trackList.Where(t => t.Genre == genre).ToList();
            return tracksByGenre;
        }
    }
}
