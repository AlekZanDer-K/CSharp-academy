namespace HW6;

internal class Program
{
    static void Main(string[] args)
    {
        var worker = new Worker("Михаил", 2350);
        EmployeeRegistry.AddEmployee(worker);

        var worker1 = new Worker("Екатерина", 2590);
        EmployeeRegistry.AddEmployee(worker1);

        var manager = new Manager("Константин", 4);
        manager.TargetProject = new Manager.Project("Наладка нового канала поставок из Китая", new DateTime(2025, 8, 25));
        EmployeeRegistry.AddEmployee(manager);

        var manager1 = new Manager("Мария", 2.4);
        EmployeeRegistry.AddEmployee(manager1);

        EmployeeRegistry.ListAllEmployees();

        EmployeeRegistry.FindEmployee("Мария");
        EmployeeRegistry.FindEmployee("Николай");
    }
}
