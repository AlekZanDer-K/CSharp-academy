namespace HW12;

public class User
{
    public string Name  { get; set; }
    public int Age { get; set; }
    public string Mail { get; set; }

    public User(string name, int age, string mail)
    {
        Name = name;
        Age = age;
        Mail = mail;
    }
}
