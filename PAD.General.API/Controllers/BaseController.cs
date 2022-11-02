namespace PAD.General.API.Controllers;

public abstract class BaseController<TService> : ControllerBase
{
    protected TService _service;

    protected BaseController(TService service)
    {
        _service = service;
    }

#pragma warning disable IDE0051 // Удалите неиспользуемые закрытые члены
    private Guid UserId
#pragma warning restore IDE0051 // Удалите неиспользуемые закрытые члены
    {
        get
        {
            string? userId = User.FindFirst("sub")?.Value;
            return userId != null ? Guid.Parse(userId) : Guid.Empty;
        }
    }
}
