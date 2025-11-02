namespace Homework4;

internal class Program
{
    private static void Main()
    {
        var letter = Console.ReadLine()
            ?.ToUpper()
            .Trim();

        switch (letter)
        {
            case "W":
                Console.WriteLine("Фигура перемещена вверх");
                break;
            case "S":
                Console.WriteLine("Фигура перемещена вниз");
                break;
            case "A":
                Console.WriteLine("Фигура перемещена влево");
                break;
            case "D":
                Console.WriteLine("Фигура перемещена вправо");
                break;
            case "":
                Console.WriteLine("Фигура никуда не перемещается");
                break;
            default:
                Console.WriteLine("Неверная клавиша");
                break;
        }

    }

}
