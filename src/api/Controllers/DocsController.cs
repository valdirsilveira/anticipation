using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/v2/docs")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DocsController : Controller
    {
        [HttpGet, Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}