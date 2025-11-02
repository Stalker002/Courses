namespace Task1;

internal class Program
{
    private static void Main()
    {
        Console.Write("Введите число: ");
        var input = Console.ReadLine();
        if (double.TryParse(input, out var intValue))
        {
            switch (intValue)
            {
                case < 0:
                    intValue = Math.Abs(intValue);
                    Console.WriteLine($"Число по модулю: {intValue}");
                    break;
                case > 0:
                    intValue = Math.Pow(intValue, 2);
                    Console.WriteLine($"Число в квадрате: {intValue}");
                    break;
                case 0:
                    Console.WriteLine("Это ноль");
                    break;
            }
        }
        else Console.WriteLine("Неверный ввод");
    }
}
