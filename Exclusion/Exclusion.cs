namespace Exclusions;

public class MException : Exception
{
    public int? ErrorCode { get; }

    public MException()
    {
    }

    public MException(string? message) : base(message)
    {
    }

    public MException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public MException(string? message, int errorCode) : base(message)
    {
        ErrorCode = errorCode;
    }
}