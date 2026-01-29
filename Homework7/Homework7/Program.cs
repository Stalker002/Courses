namespace Homework7;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person { Name = "Alice", Age = 23 };
        var p2 = new Person { Name = "Alice", Age = 23 };
        var p3 = new Person { Name = "Misha", Age = 21 };

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(p3.ToString());

        Console.WriteLine();

        Console.WriteLine(p1.Equals(p2));
        Console.WriteLine(p2.Equals(p3));

        Console.WriteLine();

        Console.WriteLine(p1 == p2);
        Console.WriteLine(p2 == p3);
        Console.WriteLine($"Не равны: {p2 != p3}");

        Console.WriteLine();

        Console.WriteLine(p1.GetHashCode());
        Console.WriteLine(p2.GetHashCode());
        Console.WriteLine(p3.GetHashCode());

        Console.WriteLine();

        Console.WriteLine($"P1 старше p3: {p1 > p3}");
        Console.WriteLine($"P3 младше p1: {p3 < p1}");
    }
}
