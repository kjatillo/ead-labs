using System.Xml;

namespace exercise2;

public class ToDoNote : ISerialisedXML
{
    // Fields
    private string? subject;
    private DateTime dueDate;
    private Priority priority;

    // Properties
    public string? Subject
    {
        get
        {
            return this.subject;
        }
        set
        {
            this.subject = value;
        }
    }

    public DateTime DueDate
    {
        get
        {
            return this.dueDate;
        }
        set
        {
            this.dueDate = value;
        }
    }

    public Priority Priority
    {
        get
        {
            return this.priority;
        }
        set
        {
            this.priority = value;
        }
    }

    // Constructor
    public ToDoNote(string subject,  DateTime dueDate, Priority priority)
    {
        this.subject = subject;
        this.dueDate = dueDate;
        this.priority = priority;
    }

    // Methods
    public override string ToString()
    {
        return $"Subject: {Subject} | Due Date: {DueDate.ToShortDateString()} | Priority: {Priority.ToString()}";
    }

    public void ToXML(string fileName)
    {
        XmlTextWriter tw = new XmlTextWriter(fileName, System.Text.Encoding.UTF8);
        tw.Formatting = Formatting.Indented;
        tw.WriteStartDocument();
        tw.WriteStartElement("Tp-Do-Note");
        tw.WriteElementString("Subject", Subject);
        tw.WriteElementString("Due-Date", DueDate.ToString());
        tw.WriteElementString("Priority", Priority.ToString("d"));
        tw.WriteEndElement();
        tw.WriteEndDocument();

        tw.Flush();
        tw.Close();
    }
}
