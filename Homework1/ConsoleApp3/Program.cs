namespace Homework3;

internal class Program
{
    private static void Main()
    {
        var intValue = 0;

        do
        {
            intValue -= 20;
            Console.WriteLine(intValue);
        }while (intValue != -100);
    }
}
