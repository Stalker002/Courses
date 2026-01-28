namespace Homework6;

public class Program()
{
    static void Main(string[] args)
    {
        var studentsList = new List<Student>
        {
            new("Misha", 17, 9.3),
            new("Roma", 18, 9.7),
            new("Denis", 16, 9.3)
        };


        foreach (var item in studentsList)
        {
            Console.WriteLine($"Имя: {item.Name}, Средний бал: {item.AvgScore}, Возраст: {item.Age}");
        }

        var youngest = studentsList.MinBy(s => s.Age);

        Console.WriteLine($"Самый младший студент: {youngest.Name} {youngest.Age} лет, средний бал - {youngest.AvgScore} ");

        var sortedDesc = studentsList
            .OrderByDescending(s => s.AvgScore)
            .ToList();

        Console.WriteLine($"Отсортированный список студентов по среднему балу: ");

        foreach (var item in sortedDesc)
        {
            Console.WriteLine($"Имя: {item.Name}, Средний бал: {item.AvgScore}, Возраст: {item.Age}");
        }
    }
}
