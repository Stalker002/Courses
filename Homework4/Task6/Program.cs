namespace Task5;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите размеры квадратной матрицы: ");
        var len = Convert.ToInt32(Console.ReadLine());

        var mass = new int[len,len];
        var value = new Random();

        Console.WriteLine("Исходная матрица: ");
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (var j = 0; j < mass.GetLength(1); j++)
            {
                mass[i, j] = value.Next(1, 10);
                Console.Write(mass[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Транспонированная матрица: ");
        for (int i = 0; i < mass.GetLength(0); i++)
        {
            for (int j = 0; j < mass.GetLength(1); j++)
            {
                Console.Write(mass[j, i] + " ");
            }
            Console.WriteLine();
        }
    }
}