namespace exercise2;

public class ToDoList
{
    // Fields
    private string? owner;
    private List<ToDoNote>? notes;

    // Properties
    public string? Owner
    {
        get
        {
            return owner;
        }
        set
        {
            owner = value;
        }
    }

    public int? Length
    {
        get
        {
            return notes?.Count;
        }
    }

    // Constructor
    public ToDoList(string owner)
    {
        this.owner = owner;
        notes = new List<ToDoNote>();
    }

    // Indexer
    public ToDoNote this[int index]
    {
        get
        {
            if (index >= 0 && index < notes?.Count)
            {
                return notes[index];
            }
            else
            {
                throw new ArgumentException("Index out of bounds!");
            }
        }
    }

    // Method
    public void Add(ToDoNote note)
    {
        notes?.Add(note);
    }
}
