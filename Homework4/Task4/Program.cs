namespace Task4;

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

        var writeIndex = 0;
        for (int read = 0; read < mass.Length; read++)
        {
            if (mass[read] != 0)
            {
                mass[writeIndex++] = mass[read];
            }
        }
        for (int i = writeIndex; i < mass.Length; i++)
        {
            mass[i] = 0;
        }

        Console.Write("Результат: ");
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(mass[i] + " ");
        }
        Console.WriteLine();
    }
}