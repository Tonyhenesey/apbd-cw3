using System.Runtime.Serialization;

namespace ConsoleApp1.Exceptions;

public class OverFillException : Exception
{
    public OverFillException()
    {
        Console.WriteLine("ATENTION PLEASE!\n" +
                          "OVERFILL INCOMING\n" +
                          "PLEASE FILL CONTAINER WITH LIGHTER LOAD"); 
    }

    protected OverFillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public OverFillException(string? message) : base(message)
    {
        
    }

    public OverFillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}