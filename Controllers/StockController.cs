using LearningScripts.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearningScripts.Controllers
{
    public class StockController : Controller
    {
        private readonly MyService _myService;
        public StockController(MyService myService)
        {
            _myService = myService;
        }
        [Route("/stock")]
        public async Task<IActionResult> Index()
        {
            await _myService.method();
            return View();
        }
    }
}
