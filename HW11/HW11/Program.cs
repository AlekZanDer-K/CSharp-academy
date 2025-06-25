using HW11.Exceptions;

namespace HW11;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Укажите координаты 2х точек в координатной сетке X(-10, 10) и Y(-10, 10), для вычисления его длины\n");
        
        Console.Write("ВВедите координату первой точки:\nX1:");
        var x1 = Console.ReadLine();
        Console.Write("Y1:");
        var y1 = Console.ReadLine();
        Console.Write("\nВВедите координату второй точки:\nX2:");
        var x2 = Console.ReadLine();
        Console.Write("Y2:");
        var y2 = Console.ReadLine();
        
        try
        {
            LineSegment2D.GetLineLength(x1, y1, x2, y2);
        }

        catch (OutsideTheCoordinateGridException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
