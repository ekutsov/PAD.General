namespace PAD.Extensions.Exceptions;

public class UnauthorizedException : ExceptionBase
{
    public UnauthorizedException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.Unauthorized;
}
