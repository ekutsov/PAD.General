namespace PAD.General.API.Controllers;

public abstract class BaseController<TService> : ControllerBase
{
    protected TService _service;

    protected BaseController(TService service)
    {
        _service = service;
    }

    protected ActionResult<Response<T>> ResponseResult<T>(T result) =>
        new Response<T>(result);
}
