namespace HW6;

public abstract class EmployeeBase
{
    public string Name { get; set; }
    public string Position { get; set; }

    public EmployeeBase(string name, string position)
    {
        Name = name;
        Position = position;
    }

    public abstract void GetDetails();
}
