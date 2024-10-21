namespace exercise3;

public abstract class MediaFile
{
    // Field
    private string? fileName;

    // Property
    public string? FileName
    {
        get
        {
            return fileName;
        }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                fileName = value;
            }
            else
            {
                throw new ArgumentException("File name must not be null or empty!");
            }
        }
    }

    // Constructor
    public MediaFile(string fileName)
    {
        FileName = fileName;
    }

    public override string ToString()
    {
        return $"Filename: {FileName}";
    }
}
