namespace Homework3;

public class Worker : EmployeeBase
{
    public Worker(string name, string position, string phoneNumber) : base(name, position)
    {
        PhoneNumber = phoneNumber;
    }
    
    public string PhoneNumber { get; set; }

    public override void GetDetails()
    {
        Console.WriteLine($"Имя работника: {Name}, Должность: {Position}, Номер телефона: {PhoneNumber}");
    }
}
