namespace Homework4;

public static class Program
{
    private static void Main()
    {
        var array = new int[6];
        var value = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = value.Next(0,100);
        Console.Write("Массив: ");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Array.Sort(array);
        Array.Reverse(array);
        Console.WriteLine();
        Console.Write("Отсортированный массив: ");
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }

        var array2 = new int[,]
        {
            {1, 2, 3}, 
            {4, 5, 6},
            {6, 7, 8}
        };

        Console.WriteLine();

        for (int i = 0; i < array2.GetLength(0); i++)
        {
            var max = 0;
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                if (array2[i,j] > max) max = array2[i,j];
            }
            Console.WriteLine($"Максимальное значение в {i+1} строке: {max}");
        }
    }
}