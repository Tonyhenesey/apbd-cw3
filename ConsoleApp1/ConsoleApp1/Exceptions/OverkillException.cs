using System.Runtime.Serialization;

namespace ConsoleApp1.Exceptions;

public class OverkillException : Exception
{
    public OverkillException()
    {
    }

    protected OverkillException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public OverkillException(string? message) : base(message)
    {
    }

    public OverkillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}