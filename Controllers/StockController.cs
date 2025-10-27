using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class StockController : Controller
    {
        [Route("/stock")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
