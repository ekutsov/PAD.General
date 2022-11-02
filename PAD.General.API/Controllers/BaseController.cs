namespace PAD.General.API.Controllers;

public abstract class BaseController<TService> : ControllerBase
{
    protected TService _service;

    protected BaseController(TService service)
    {
        _service = service;
    }

    protected Guid UserId
    {
        get
        {
            string? userId = User.FindFirst("sub")?.Value;
            return userId != null ? Guid.Parse(userId) : Guid.Empty;
        }
    }
}
