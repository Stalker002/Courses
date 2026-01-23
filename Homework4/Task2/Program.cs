namespace Task2;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите длину массива: ");
        var n = Convert.ToInt32(Console.ReadLine());

        var mass = new int[n];
        var value = new Random();
        var sum = 0;

        Console.Write("Массив: ");
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = value.Next(1, 100);
            Console.Write(mass[i] + " ");
        }
        var min = mass[0];
        var max = mass[0];

        for (int i = 0; i < mass.Length; i++)
        {
           if (mass[i] < min) min = mass[i];
           if (mass[i] > max) max = mass[i];
        }

        Console.WriteLine();
        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
        Console.Write("Реверс массив: ");
        for (var i = mass.GetUpperBound(0); i >= 0; i--)
        {
            Console.Write(mass[i] + " ");
        }

        var puk = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] % 2 == 0) puk++; 
        }
        Console.WriteLine();
        Console.WriteLine($"Количество четных чисел: {puk}");

        var arr = Array.FindAll(mass, x => x % 2 == 0);
        Console.WriteLine($"Количество четных чисел: {arr.Length}");
    }
}