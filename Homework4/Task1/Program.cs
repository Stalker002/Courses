namespace Task1;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите длину массива: ");
        var n = Convert.ToInt32(Console.ReadLine());

        var mass = new int[n];
        var value = new Random();
        var sum = 0;

        for (int i = 0; i < n; i++)
        {
            mass[i] = value.Next(1, 20);
            sum += mass[i];
            Console.Write(mass[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов массива: {sum}");
    }
}