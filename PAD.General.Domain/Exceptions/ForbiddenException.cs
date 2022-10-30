namespace PAD.General.Domain.Exceptions;

public class ForbiddenException : ExceptionBase
{
    public ForbiddenException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.Forbidden;
}
