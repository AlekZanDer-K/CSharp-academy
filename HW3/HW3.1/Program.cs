namespace HW3._1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Для определения возрастной группы, введите полное количество лет:\n");
        var userAgeStr = Console.ReadLine();
        
        if (userAgeStr == "")
        {
            Console.WriteLine("Возраст не был введён!");
        }
        else
        {
            var userAgeInt = Convert.ToInt32(userAgeStr);
            if (userAgeInt < 0)
            {
                Console.WriteLine("Возраст не может быть отрицательным!");
            }
            else if (userAgeInt >= 0 && userAgeInt <= 2)
                {
                    Console.WriteLine("\nВаша возрастная группа: младенец.");
                }
                else if (userAgeInt >= 3 && userAgeInt <= 12)
                    {
                        Console.WriteLine("\nВаша возрастная группа: ребёнок.");
                    }
                    else if (userAgeInt >= 13 && userAgeInt <= 17)
                        {
                            Console.WriteLine("\nВаша возрастная группа: подросток.");
                        }
                        else if (userAgeInt > 18 && userAgeInt <= 59)
                            {
                                Console.WriteLine("\nВаша возрастная группа: взрослый.");
                            }
                            else
                            {
                                Console.WriteLine("\nВаша возрастная группа: пожилой.");
                            }
            var ageParityCheck = userAgeInt % 2 == 0 ? "Возраст чётный." : "Возраст нечётный.";
            Console.WriteLine(ageParityCheck);
         }
        Console.ReadKey();
    }
}
