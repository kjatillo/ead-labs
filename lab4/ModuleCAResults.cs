using System.Text;

namespace lab4;

public class ModuleCAResults
{
    // Properties
    public string? ModuleName { get; set; }
    public int Credit { get; set; }
    public string? StudentName { get; set; }


    private List<double> results = new List<double>();

    // Methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Module: {ModuleName} | Credits: {Credit} | Student Name: {StudentName}\nResults: ");
        
        foreach (double result in results)
        {
            sb.Append(result + " ");
        }

        return sb.ToString();
    }

    // Indexer
    public double this[int CA]
    {
        get
        {
            int index = CA - 1;
            if (index >= 0 && index < results.Count)
            {
                return results[index];
            }
            else
            {
                throw new ArgumentException("Invalid CA number");
            }
        }
        set
        {
            int index = CA - 1;
            if (index >= 0 && index <= results.Count)
            {
                if (index < results.Count)
                {
                    results[index] = value;
                }
                else
                {
                    results.Add(value);
                }
            }
            else
            {
                throw new ArgumentException("Invalid CA number");
            }
        }
    }
}
