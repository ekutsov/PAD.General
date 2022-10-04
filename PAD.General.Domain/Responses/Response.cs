namespace PAD.General.Domain.Responses;

public class Response<T> : ResponseBase
{
    public Response(T result) : base()
    {
        Data = result;
    }

    public T Data { get; set; }
}
