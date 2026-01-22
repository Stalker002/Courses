namespace Task3;
public class Program
{
    private static void Main()
    {
        Console.Write("Введите число соответствующее дню недели: ");
        var input = Console.ReadLine();
        if (int.TryParse(input, out var weekday))
        {
            switch (weekday)
            {
                case >= 0 and <= 5:
                    Console.WriteLine("Будний день");
                    break;
                case > 5 and <= 7:
                    Console.WriteLine("Выходной день");
                    break;
                default:
                    Console.WriteLine("Дня не существует");
                    break;
            }
        }
        else Console.WriteLine("Неверный ввод");
    }
}
