namespace ConsoleApp7;

// Создать класс Person с методом Walk(), который выводит на экран надпись “Человек прошел 500 метров”;
// Создать массив из 5 людей и в цикле вызвать метод Walk();
// Создать класс Horse с методом Walk(), который выводит на экран надпись “Лошадь прошла 5000 метров”;
// Создать интерфейс IWalkable с методом Walk();
// Добавить реализацию этого интерфейса в обоих классах.
//     Поменять тип объектов на интерфейс в массиве и в цикле;
// Добавить в массив 5 экземпляров Horse;
// *Создать интерфейс IMoveable с методом void Move(); и реализовать его в обоих классах.


class Program
{
    static void Main(string[] args)
    {
        IWalkable[] people = new IWalkable [] {new Person(), new  Horse(), new Person(), new Person(), new Horse()};
        foreach (var person in people)
        {
            person.Walk();
        }
    }
}