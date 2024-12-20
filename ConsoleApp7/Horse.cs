namespace ConsoleApp7;

public class Horse : IWalkable, IMoveable
{
    public void Walk()
    {
        Console.WriteLine("Лошадь прошла 5000 метров");
    }

    public void Move()
    {
        Console.WriteLine("Лошадь переместилась на 5000 метров");
    }
}