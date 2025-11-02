namespace Homework1;

internal class Program
{
    private static void Main()
    {
        var array = new int[10];
        var randomValue = new Random();
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = randomValue.Next(0,100);
        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}
