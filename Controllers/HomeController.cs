using Microsoft.AspNetCore.Mvc;

namespace CfDefaultAppDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
