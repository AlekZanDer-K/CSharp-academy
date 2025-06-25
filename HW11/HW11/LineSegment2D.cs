using HW11.Exceptions;

namespace HW11;

internal static class LineSegment2D
{
    public static void GetLineLength(string pointOneX, string pointOneY, string pointTwoX, string pointTwoY) 
    {
        if (!string.IsNullOrEmpty(pointOneX) || !string.IsNullOrEmpty(pointOneY) || !string.IsNullOrEmpty(pointTwoX) || !string.IsNullOrEmpty(pointTwoY))
        {
            if (double.TryParse(pointOneX, out _) || double.TryParse(pointOneY, out _) || double.TryParse(pointTwoX, out _) || double.TryParse(pointTwoY, out _))
            {
                var x1 = double.Parse(pointOneX);
                var y1 = double.Parse(pointOneY);
                var x2 = double.Parse(pointTwoX);
                var y2 = double.Parse(pointTwoY);

                if (x1 > 10 || x1 < -10 || y1 > 10 || y1 < -10)
                {
                    throw new OutsideTheCoordinateGridException("точка с координатами (x1, y1) за пределами координатной сетки");
                }

                if (x2 > 10 || x2 < -10 || y2 > 10 || y2 < -10)
                {
                    throw new OutsideTheCoordinateGridException("точка с координатами (x2, y2) за пределами координатной сетки");
                }

                var result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
                Console.WriteLine($"Длина линии {result:f2}");
            }

            else 
            {
                throw new FormatException("значения координат должны быть числовыми");
            }
        }

        else
        {
            throw new Exception("пустые значния");
        }
    }
}
