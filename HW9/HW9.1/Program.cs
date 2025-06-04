namespace HW9._1;

internal class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Николай", 16, 8.5);
        StudentDatabase.AddStudent(student);

        var student1 = new Student("Мария", 17, 8.1);
        StudentDatabase.AddStudent(student1);

        var student2 = new Student("Арсений", 38, 9.9);
        StudentDatabase.AddStudent(student2);

        var student3 = new Student("Ольга", 16, 7.7);
        StudentDatabase.AddStudent(student3);

        var student4 = new Student("", -7, -3);
        StudentDatabase.AddStudent(student4);

        StudentDatabase.FindYoungStudent();

        StudentDatabase.SortListByAverageScore();
    }
}
