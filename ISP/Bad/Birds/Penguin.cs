public class Penguin : IBird
{
    public void Fly()
    {
        // Penguenler uçamaz!
        throw new NotImplementedException("Penguenler uçamaz.");
    }

    public void Walk()
    {
        Console.WriteLine("Penguen yürüyor.");
    }

    public void Swim()
    {
        Console.WriteLine("Penguen yüzüyor.");
    }
}
