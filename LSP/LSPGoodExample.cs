public abstract class LspBird
{
    public abstract void Move();
}

public class GoldenEagle : LspBird
{
    public override void Move()
    {
        Fly();
    }

    private void Fly()
    {
        Console.WriteLine("Kartal uçuyor...");
    }
}

public class OstrichBird : LspBird
{
    public override void Move()
    {
        Walk();
    }

    private void Walk()
    {
        Console.WriteLine("Devekuşu yürüyor...");
    }
}
