namespace HW6;

public class Worker : EmployeeBase
{
    public double Salary { get; set; }

    public Worker(string name, double salary) : base(name, "Рабочий")
    {
        Salary = salary;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Имя: {Name}\nДолжность: {Position}\nЗаработная плата: {Salary}");
    }
}
