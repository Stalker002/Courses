using System.Text;

namespace Homework5;

public static class Program
{
    private static void Main()
    {
        Console.Write("Введите строку: ");
        var str = Console.ReadLine();
        var sb = new StringBuilder(str.Length);
        foreach (var ch in str)
        {
            if (char.IsLetterOrDigit(ch))
                sb.Append(char.ToLowerInvariant(ch));
        }

        int i = 0, j = sb.Length - 1;
        var res = false;
        while (i < j)
        {
            if (sb[i] == sb[j])
                res = true;
            i++; j--;
        }

        Console.WriteLine(res ? "Строка является палиндромом." : "Строка не является палиндромом.");
    }
}