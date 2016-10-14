using Microsoft.AspNetCore.Mvc;
using System;

namespace CfDefaultAppDotNetCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            ViewBag.EnvVariables = Environment.GetEnvironmentVariables();
            ViewBag.ReqHeaders = Request.Headers;
            ViewBag.ReqQuery = Request.Query;

            return View();
        }
    }
}
