namespace Homework3;

public class Manager : EmployeeBase
{
    public Manager(string name, string position, string email) : base(name, position)
    {
        Email = email;
    }

    public string Email { get; set; }

    public override void GetDetails()
    {
        Console.WriteLine($"Имя сотрудника: {Name}, Должность: {Position}, Электронная почта: {Email}");
    }

    public class Project
    {
        public Project(string projectName, string deadline)
        {
            ProjectName = projectName;
            Deadline = deadline;
        }
        public string ProjectName { get; set; }

        public string Deadline { get; set; }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Проект '{ProjectName}' должен быть завершен к {Deadline}");
        }
    }
}
