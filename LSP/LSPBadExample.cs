public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Uçuyor...");
    }

    public virtual void Move()
    {
        Console.WriteLine("Hareket ediyor...");
    }
}

public class Eagle : Bird
{
    // Doğru: Kartal uçar
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotSupportedException("Devekuşu uçamaz!");
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
