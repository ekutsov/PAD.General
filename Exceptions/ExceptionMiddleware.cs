namespace PAD.Extensions.Exceptions;

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
            await httpContext.OverrideResponse(exception);
        }
    }
}

public static class ExceptionMiddlewareExtentions
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionMiddleware>();
    }

    public static async Task OverrideResponse(this HttpContext httpContext, Exception exception)
    {
        ResponseBase response = new(exception is ExceptionBase exceptionBase ? exceptionBase : exception);

        if (!httpContext.Response.HasStarted)
        {
            httpContext.Response.Clear();
            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = (int)response.StatusCode;
            await httpContext.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
        else
            throw new InvalidException(response.UserMessage);
    }
}
