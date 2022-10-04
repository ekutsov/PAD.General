namespace PAD.General.Domain.Exceptions;

public class UnauthorizedException : ExceptionBase
{
    public UnauthorizedException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;
}
