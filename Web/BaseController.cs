namespace PAD.Extensions.Web;

public abstract class BaseController<TService> : Controller
{
    protected TService _service;

    protected BaseController(TService service)
    {
        _service = service;
    }

    protected ActionResult<Response<T>> DataResult<T>(T result) =>
        Json(new Response<T>(result));
}
