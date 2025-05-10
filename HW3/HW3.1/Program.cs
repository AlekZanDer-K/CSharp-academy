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
            else
            {
                Console.Write("\nВаша возрастная группа: ");
                if (userAgeInt >= 0 && userAgeInt <= 2)
                {
                    Console.WriteLine("младенец.");
                }
                else
                {
                    if (userAgeInt >= 3 && userAgeInt <= 12)
                    {
                        Console.WriteLine("ребёнок.");
                    }
                    else
                    {
                        if (userAgeInt >= 13 && userAgeInt <= 17)
                        {
                            Console.WriteLine("подросток.");
                        }
                        else
                        {
                            if (userAgeInt > 18 && userAgeInt <= 59)
                            {
                                Console.WriteLine("взрослый.");
                            }
                            else
                            {
                                Console.WriteLine("пожилой.");
                            }
                        }
                    }
                }
            }
            var ageParityCheck = userAgeInt % 2 == 0 ? "Возраст чётный." : "Возраст нечётный.";
            Console.WriteLine(ageParityCheck);
         }
        Console.ReadKey();
    }
}
