namespace Homework6._3;

public class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        var input = Console.ReadLine();

        var wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        if (input != null)
        {
            var words = input.Split([' ', '.', ',', '!', '?'], StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                if (wordCount.TryGetValue(word, out int value))
                {
                    wordCount[word] = ++value;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }
            Console.WriteLine("Количество вхождений каждого слова:");
            foreach (var item in wordCount)
            {
                Console.WriteLine($"Слово: {item.Key} Количество: {item.Value}");
            }
        }
    }
}
