namespace HW9._1;

internal class Student
{
    private string _name;
    private int _age;
    private double _averageScore;

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                _name = "Unnamed";
            }
            else
            {
                _name = value;
            }
        }
    }
    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            if (value <= 0)
            {
                _age = 0;
            }
            else
            {
                _age = value;
            }
        }
    }
    public double AverageScore
    {
        get
        {
            return _averageScore;
        }

        set
        {
            if (value < 0)
            {
                _averageScore = -1;
            }
            else
            {
                _averageScore = value;
            }
        }
    }

    public Student(string name, int age, double averageScore) 
    {
        Name = name;
        Age = age;
        AverageScore = averageScore;
    }

    public void GetStudentInfo() 
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Средний бал: {AverageScore}");
    }
}
