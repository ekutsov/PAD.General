namespace PAD.General.Domain.Exceptions;

public class NotFoundException : ExceptionBase
{
    public NotFoundException(string? message) : base(message) { }

    public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;
}
