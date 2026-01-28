namespace Homework6._2;

public class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            { "Apple", 1.2 },
            { "Banana", 0.8 },
            { "Orange", 1.5 },
            { "Grapes", 2.0 }
        };

        foreach (var item in products)
        {
            Console.WriteLine($"Название продукта: {item.Key} Цена: {item.Value}");
        }

        Console.Write("Введите название продукта чтобы найти: ");
        var input = Console.ReadLine();

        if (input != null && products.TryGetValue(input, out var price))
        {
            Console.WriteLine($"Цена продукта {input}: {price}");
        }
        else
        {
            Console.WriteLine("Продукт не найден.");
        }

        foreach (var item in products)
        {
            products[item.Key] *= 1.1;
        }
        foreach (var item in products)
        {
            Console.WriteLine($"Название продукта: {item.Key} Цена: {item.Value}");
        }
    }
}
