namespace Task2
{
    internal class Program
    {
        private static void Main()
        {
            for (var i = 1; i <= 10; i++)
            {
                for (var j = 1; j <= 10; j++)
                {
                    var result = j * i;
                    Console.Write($"{j} * {i} = {result}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
