namespace Homework3;

public static class EmployeeRegistry
{
    public static List<EmployeeBase>? Employees { get; set; } = new();

    public static void AddEmployee(EmployeeBase employee)
    {
        Employees?.Add(employee); 
    }

    public static void ListAllEmployees()
    {
        foreach (var e in Employees)
        {
            e.GetDetails();
        }
    }

    public static void FindEmployee(string name)
    {
        var found = Employees?.FirstOrDefault(e => string.Equals(e.Name, name, StringComparison.OrdinalIgnoreCase));

        if (found is null)
            Console.WriteLine($"Сотрудник с именем '{name}' не найден.");
        else
        { 
            Console.Write($"Сотрудник найден: "); 
            found.GetDetails();
        }
    }
}
