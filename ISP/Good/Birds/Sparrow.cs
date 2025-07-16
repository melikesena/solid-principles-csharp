public class GoodSparrow : IFlyable, IWalkable
{
    public void Fly()
    {
        Console.WriteLine("Serçe uçuyor.");
    }

    public void Walk()
    {
        Console.WriteLine("Serçe yürüyor.");
    }
}
