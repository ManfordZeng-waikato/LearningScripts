using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICitiesService _citiesService;
        private readonly ICitiesService _citiesService1;
        private readonly ICitiesService _citiesService2;

        public CitiesController(ICitiesService citiesService,
            ICitiesService citiesService1, ICitiesService citiesService2)
        {
            //citiesService = new CitiesService();
            _citiesService = citiesService;
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService.GetCities();

            ViewBag._citiesServiceId = _citiesService.ServiceInstanceId;
            ViewBag._citiesServiceId1 = _citiesService1.ServiceInstanceId;
            ViewBag._citiesServiceId2 = _citiesService2.ServiceInstanceId;

            return View(cities);
        }
    }
}
