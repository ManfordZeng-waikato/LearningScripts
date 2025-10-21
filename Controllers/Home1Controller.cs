using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class Home1Controller : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "Paris",
                "Rome",
                "Tokyo",
                "Pei Jing"
            };
            return View();
        }

        [Route("about-company")]
        public IActionResult About()
        {
            ViewData["ListTitle"] = "Cities";
            ViewData["ListItems"] = new List<string>()
            {
                "Paris",
                "Rome",
                "Tokyo",
                "Pei Jing"
            };
            return View();
        }

        [Route("contact-support")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
