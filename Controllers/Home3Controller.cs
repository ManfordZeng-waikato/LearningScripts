using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class Home3Controller : Controller
    {
        [Route("home")]
        public IActionResult Index()
        {
            //views/Home/Index.cshtml
            return View();

            //abc.cshtnl
            //return View("abc");
        }
    }
}
