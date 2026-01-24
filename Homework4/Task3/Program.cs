namespace Task3;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите массив чисел через пробел: ");
        var input = Console.ReadLine();

        var parts = input.Split([' ', '\t'], StringSplitOptions.RemoveEmptyEntries);
        var mass = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            mass[i] = int.Parse(parts[i]);
        }

        Console.Write("Введите число для поиска: ");
        var s = Console.ReadLine();
        var target = int.Parse(s);

        Console.Write("Массив: ");
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(mass[i] + (i + 1 == mass.Length ? "" : " "));
        }
        Console.WriteLine();

        var found = Array.Exists(mass, x => x == target);
        Console.WriteLine(found ? "Число найдено." : "Число не найдено.");
    }
}