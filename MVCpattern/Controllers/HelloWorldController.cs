using Microsoft.AspNetCore.Mvc;
using MVCpattern.Models;

namespace MVCpattern.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new DogViewModel() { Name="Doggie", Age=2 };
            return View(dog);
        }

        public IActionResult Create()
        {
            return View();
        }

        public String Hello()
        {
            return "Who's there";
        }
    }
}
