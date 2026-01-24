namespace Task5;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите размеры строки массива: ");
        var lines = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите размеры столбцов массива: ");
        var columns = Convert.ToInt32(Console.ReadLine());

        var mass = new int[lines, columns];
        var value = new Random();

        Console.WriteLine("Массив: ");
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (var j = 0; j < mass.GetLength(1); j++)
            {
                mass[i,j] = value.Next(1, 10);
                Console.Write(mass[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            var sum = 0;
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                sum += mass[i, j];
            }
            Console.WriteLine($"Сумма элементов в {i + 1} строке: {sum}");
        }

        for (int i = 0; i < mass.GetLength(0); i++)
        {
            var min = mass[i,0];
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                if (mass[i, j] < min) min = mass[i, j];
            }
            Console.WriteLine($"Минимальное значение в {i + 1} строке: {min}");
        }
    }
}