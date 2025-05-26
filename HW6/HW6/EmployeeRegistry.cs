namespace HW6;

static class EmployeeRegistry
{
    public static List<EmployeeBase> employeesList = new List<EmployeeBase>();

    public static EmployeeBase AddEmployee(EmployeeBase employee)
    {
        employeesList.Add(employee);
        return employee;
    }

    public static void ListAllEmployees()
    {
        Console.WriteLine("Список сотрудников компании: ");
        Console.WriteLine("-------------------------------------------");
        foreach (var employee in employeesList)
        {
            employee.GetDetails();
            Console.WriteLine("-------------------------------------------");
        }
    }

    public static void FindEmployee(string name)
    {
        Console.WriteLine($"\nРезультаты поиска по имени {name}:\n");
        var i = 0;
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Сотрудника с таким именем нет в списке.");
        }
        else
        {
            foreach (var employee in employeesList)
            {
                if (employee.Name.ToLower() == name.ToLower())
                {
                    i++;
                    employee.GetDetails();
                }
            }
            if (i == 0)
            {
                Console.WriteLine("Сотрудника с таким именем нет в списке.");
            }
        }
    }
}
