using System.Runtime.Serialization;

namespace ConsoleApp1.Exceptions;

public class SameSerialNumberException : Exception
{
    public SameSerialNumberException()
    {
        Console.WriteLine("Given serial number already exist in this container class. Please provide new one");
    }
    
}