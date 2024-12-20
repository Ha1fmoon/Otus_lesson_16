namespace ConsoleApp7;

public class Person : IWalkable, IMoveable
{
    public void Walk()
    {
        Console.WriteLine("Человек прошел 500 метров");
    }

    public void Move()
    {
        Console.WriteLine("Человек переместился на 5000 метров");
    }
}