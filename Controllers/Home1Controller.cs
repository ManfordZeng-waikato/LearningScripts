using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class Home1Controller : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about-company")]
        public IActionResult About()
        {
            return View();
        }

        [Route("contact-support")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("language")]
        public IActionResult Language()
        {
            ListModel listModel = new ListModel()
            {
                ListTitle = "Language",
                ListItems = new List<string>()
                {
                "Chinese",
                "Japanese",
                "English",
                "Hindi",
                }
            };

            return PartialView("_ListPartialView", listModel);
        }
    }
}
