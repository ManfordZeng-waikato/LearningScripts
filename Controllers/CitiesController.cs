using Microsoft.AspNetCore.Mvc;
using Services;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        private readonly CitiesService citiesService;

        public CitiesController()
        {
            citiesService = new CitiesService();
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = citiesService.GetCities();
            return View(cities);
        }
    }
}
