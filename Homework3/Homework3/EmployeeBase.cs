namespace Homework3;

public abstract class EmployeeBase
{
    protected EmployeeBase(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public string Name { get; set; }

    public string Position { get; set; }

    public abstract void GetDetails();
}
