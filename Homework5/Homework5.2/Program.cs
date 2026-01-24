using System.Text;

namespace Homework5._2;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите строку: ");
        var str = Console.ReadLine();

        var sb = new StringBuilder(str.Length);
        foreach (var ch in str)
        {
            if (!char.IsWhiteSpace(ch))
                sb.Append(ch);
        }

        var noSpace = sb.ToString();
        Console.WriteLine($"Без пробелов: {noSpace}");

        var upper = str.ToUpper();
        Console.WriteLine($"Все заглавные: {upper}");

        var lower = str.ToLower();
        Console.WriteLine($"Все строчные: {lower}");

        var init = new StringBuilder(str.Length);
        bool newWord = true;
        foreach (var ch in str)
        {
            if (char.IsLetterOrDigit(ch))
            {
                if (newWord)
                    init.Append(char.ToUpper(ch));
                else
                    init.Append(char.ToLower(ch));

                newWord = false;
            }
            else
            {
                init.Append(ch);
                newWord = true;
            }
        }

        var initText = init.ToString();
        Console.WriteLine($"Первая буква каждого слова в заглавной: {initText}");
    }
}