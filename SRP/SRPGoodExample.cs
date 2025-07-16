public class CustomReport
{
    public string Title { get; set; }
    public string Content { get; set; }
}

public class ReportPrinter
{
    public void Print(CustomReport report)
    {
        Console.WriteLine(report.Title);
        Console.WriteLine(report.Content);
    }
}

public class ReportSaver
{
    public void SaveToFile(CustomReport report, string path)
    {
        File.WriteAllText(path, report.Content);
    }
}