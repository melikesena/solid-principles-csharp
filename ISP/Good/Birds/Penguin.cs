public class GoodPenguin : IWalkable, ISwimmable
{
    public void Walk()
    {
        Console.WriteLine("Penguen yürüyor.");
    }

    public void Swim()
    {
        Console.WriteLine("Penguen yüzüyor.");
    }
}
