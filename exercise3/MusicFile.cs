namespace exercise3;

public class MusicFile : MediaFile
{
    // Fields
    private string? title;
    private string? artist;
    private Genre genre;

    // Properties
    public string? Title
    {
        get
        {
            return title;
        }
    }

    public string? Artist
    {
        get
        {
            return artist;
        }
    }

    public Genre Genre
    {
        get
        {
            return genre;
        }
    }

    // Constructor
    public MusicFile(string fileName, string title, string artist, Genre genre) : base(fileName)
    {
        if (!string.IsNullOrEmpty(title))
        {
            this.title = title;
        }
        else
        {
            throw new ArgumentException("Title must not be null or empty!");
        }

        if (!string.IsNullOrEmpty(artist))
        {
            this.artist = artist;
        }
        else
        {
            throw new ArgumentException("Artist must not be null or empty!");
        }

        this.genre = genre;
    }

    public MusicFile(string fileName, string title, string artist) : base(fileName)
    {
        if (!string.IsNullOrEmpty(title))
        {
            this.title = title;
        }
        else
        {
            throw new ArgumentException("Title must not be null or empty!");
        }

        if (!string.IsNullOrEmpty(artist))
        {
            this.artist = artist;
        }
        else
        {
            throw new ArgumentException("Artist must not be null or empty!");
        }

        this.genre = Genre.Other;
    }

    // Methods
    public override string ToString()
    {
        return $"Title: {Title} | Artist: {Artist} | Genre: {Genre}";
    }
}
