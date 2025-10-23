using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICitiesService citiesService;

        public CitiesController()
        {
            //citiesService = new CitiesService();
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = citiesService.GetCities();
            return View(cities);
        }
    }
}
