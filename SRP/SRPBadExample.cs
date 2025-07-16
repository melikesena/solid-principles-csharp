public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public void SaveToFile(string path)
    {
        File.WriteAllText(path, Content);
    }

    public void Print()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Content);
    }
}