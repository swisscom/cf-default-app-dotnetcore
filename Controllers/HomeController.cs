using Microsoft.AspNetCore.Mvc;

namespace CfDefaultAppDotNet.Controllers
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
