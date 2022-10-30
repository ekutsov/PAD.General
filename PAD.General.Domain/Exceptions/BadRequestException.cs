namespace PAD.General.Domain.Exceptions;

public class BadRequestException : ExceptionBase
{
    public BadRequestException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.BadRequest;
}
