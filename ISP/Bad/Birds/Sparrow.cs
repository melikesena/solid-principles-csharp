public class Sparrow : IBird
{
    public void Fly()
    {
        Console.WriteLine("Serçe uçuyor.");
    }

    public void Walk()
    {
        Console.WriteLine("Serçe yürüyor.");
    }

    public void Swim()
    {
        // Serçeler yüzemez!
        throw new NotImplementedException("Serçeler yüzemez.");
    }
}
