using Microsoft.AspNetCore.Mvc;

namespace MVCpattern.Controllers
{
    public class HelloWorldController : Controller
    {
        public String Index()
        {
            return "This is the index page";
        }

        public String Hello()
        {
            return "Who's there";
        }
    }
}
