namespace HW11.Exceptions;
 
public class OutsideTheCoordinateGridException : Exception
{
    public OutsideTheCoordinateGridException(string message) : base(message)
    {

    }
}
