namespace HW4._4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Для перемещения фигуры нажмите W (вперёд) ,A (влево) ,S (назад), D (вправо) или Space (остаться на месте)." +
                          $"\nДля выхода нажмите клавишу Esc:");
        for ( ; ; )
        {
            var movmentKey = Console.ReadKey(true).KeyChar;
            movmentKey = char.ToLower(movmentKey);
            if (movmentKey == '\u001b')
            {
                break;
            }
            else
            {
                string resoult = movmentKey switch
                {
                    'w' => "Фигура перемещена вперёд.",
                    'a' => "Фигура перемещена влево.",
                    's' => "Фигура перемещена назад.",
                    'd' => "Фигура перемещена вправо.",
                    ' ' => "Фигура не перемещена.",
                     _  => $"{movmentKey} Недопустимая клавиша для перемещения."
                };

                Console.Clear();
                Console.WriteLine($"Для перемещения фигуры нажмите W (вперёд) ,A (влево) ,S (назад), D (вправо) или Space (остаться на месте)." +
                          $"\nДля выхода нажмите клавишу Esc:");

                Console.WriteLine($"\n{resoult}");
            }
        }
    }
}
