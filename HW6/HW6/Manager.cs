namespace HW6;

public class Manager : EmployeeBase
{
    public double WorkExperience { get; set; }
    public Project TargetProject { get; set; }

    public Manager(string name, double workExperience) : base(name, "Менеджер")
    {
        WorkExperience = workExperience;
    }

    public override void GetDetails()
    {
        Console.WriteLine($"Имя: {Name}\nДолжность: {Position}\nСтаж: {WorkExperience}");
        if (TargetProject != null)
        {
            if (string.IsNullOrEmpty(TargetProject.ProjectName) == false)
            {
                TargetProject.DisplayProjectInfo();
            }
            else Console.WriteLine("Проект не назначен.");
        }
        else
        {
            Console.WriteLine("Проект не назначен.");
        }
    }

    public class Project
    {
        public string ProjectName { get; set; }
        public DateTime Deadline { get; set; }

        public Project(string projectName, DateTime deadLine)
        {
            ProjectName = projectName;
            Deadline = deadLine;
        }

        public void DisplayProjectInfo()
        {
            Console.WriteLine($"Название проекта: {ProjectName}\nВремя сдачи проекта: {Deadline.ToLongDateString()}");
        }
    }
}
