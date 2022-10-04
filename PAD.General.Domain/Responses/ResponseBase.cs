namespace PAD.General.Domain.Responses;

public class ResponseBase
{
    #region Constructors

    public ResponseBase() { }

    public ResponseBase(string userMessage, string? systemMessage = null)
    {
        UserMessage = userMessage;
        SystemMessage = systemMessage;
        GeneratedAtUtc = DateTime.UtcNow;
    }

    public ResponseBase(ExceptionBase exception) : this(exception.Message)
    {
        StatusCode = exception.StatusCode;
    }

    public ResponseBase(Exception exception) : this(exception.Message, exception.GetType().FullName) { }

    #endregion

    public string? UserMessage { get; protected set; }

    public string? SystemMessage { get; protected set; }

    public DateTime GeneratedAtUtc { get; private set; }

    [JsonIgnore]
    public HttpStatusCode StatusCode { get; protected set; } = HttpStatusCode.InternalServerError;
}