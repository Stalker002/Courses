namespace Homework2;

internal class Program
{
    private static void Main()
    {
        var counter = 0;
        for (var i = -99; i < 100; i++)
        {
            if (i % 5 != 0) continue;
            if (i == 0) continue;
            Console.Write($"{i} ");
            counter++;
        }
        Console.WriteLine($"\nКоличество операций: {counter}");
    }
}
