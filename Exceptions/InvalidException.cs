namespace PAD.Extensions.Exceptions;

public class InvalidException : ExceptionBase
{
    public InvalidException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.InternalServerError;

}
