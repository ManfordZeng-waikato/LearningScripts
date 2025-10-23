using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        //private readonly ICitiesService _citiesService;

        //public CitiesController(ICitiesService citiesService)
        //{
        //    //citiesService = new CitiesService();
        //    _citiesService = citiesService;
        //}

        [Route("/")]
        public IActionResult Index([FromServices] ICitiesService _citiesService)
        {
            List<string> cities = _citiesService.GetCities();
            return View(cities);
        }
    }
}
