namespace PAD.Extensions.Exceptions;

public class BadRequestException : ExceptionBase
{
    public BadRequestException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;

}
