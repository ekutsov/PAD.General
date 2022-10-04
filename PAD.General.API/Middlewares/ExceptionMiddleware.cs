namespace PAD.General.API.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception exception)
        {
            ResponseBase response = new(exception is ExceptionBase exceptionBase ? exceptionBase : exception);

            if (!httpContext.Response.HasStarted)
            {
                httpContext.Response.Clear();
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)response.StatusCode;
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(response));
            }
            else
                throw new InvalidException(response.UserMessage);
        }
    }
}