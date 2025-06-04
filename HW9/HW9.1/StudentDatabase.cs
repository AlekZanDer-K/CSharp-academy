namespace HW9._1;

static class StudentDatabase
{
    private static List<Student> studentList = new List<Student>();

    public static Student AddStudent(Student student)
    {
        if (student.Name == "Unnamed" || student.AverageScore == -1 || student.Age == 0)
        {
            return null;
        }
        else 
        {
            studentList.Add(student);
            return student;
        }
    }

    public static void FindYoungStudent() 
    {
        Console.WriteLine("Самый младший студент(ы):");

        var youngAge = 100;
        for (var i = 0; i < studentList.Count; i++)
        {
            if (studentList[i].Age < youngAge)
            {
                youngAge = studentList[i].Age;
            }
        }

        foreach (Student student in studentList)
        {
            if (student.Age == youngAge)
            {
                student.GetStudentInfo();
            }
        }
    }

    private static int SortKeyAverageScore(Student student1, Student student2) 
    {
        return student1.AverageScore.CompareTo(student2.AverageScore);
    }

    public static void SortListByAverageScore()
    {
        Console.WriteLine("\nСортировка списка по среднему балу: ");
        studentList.Sort(SortKeyAverageScore);
        studentList.Reverse();
        foreach (Student student in studentList) 
        { 
            Console.WriteLine($"Средний бал: {student.AverageScore}\t Имя: {student.Name}"); 
        }
    }
}
