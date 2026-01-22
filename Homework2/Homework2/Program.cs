namespace Task1;
internal static class Program
{
    private static void Main()
    {
        var pushkin = new Book();
        var anna = new Book("Anna", "Anna", 23);

        Console.WriteLine($"Название: {anna.Title}, Автор: {anna.Author}, Кол-во страниц: {anna.Page}");

        pushkin.GetDescription();

    }
}
