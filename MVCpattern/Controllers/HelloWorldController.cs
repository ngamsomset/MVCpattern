using Microsoft.AspNetCore.Mvc;

namespace MVCpattern.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public String Hello()
        {
            return "Who's there";
        }
    }
}
