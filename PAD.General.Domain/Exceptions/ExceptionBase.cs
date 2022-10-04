namespace PAD.General.Domain.Exceptions;

public abstract class ExceptionBase : Exception
{
    protected ExceptionBase(string? message) : base(message) { }

    public abstract HttpStatusCode StatusCode { get; }
}