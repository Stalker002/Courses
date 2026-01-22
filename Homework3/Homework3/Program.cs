namespace Homework3;

public static class Program
{
    private static void Main()
    {
        var worker = new Worker("Бен", "Слесарь", "+375465675658");
        worker.GetDetails();
        EmployeeRegistry.AddEmployee(worker);

        var manager = new Manager("Михаил", "Менеджер", "michail@gmail.com");
        manager.GetDetails();
        EmployeeRegistry.AddEmployee(manager);

        EmployeeRegistry.ListAllEmployees();

        EmployeeRegistry.FindEmployee("МИхаил");

        var project = new Manager.Project("Дорога", "18 января");
        project.DisplayProjectInfo();
    }
}
