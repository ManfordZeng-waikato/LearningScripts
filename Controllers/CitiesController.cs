using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICitiesService _citiesService;
        private readonly ICitiesService _citiesService1;
        private readonly ICitiesService _citiesService2;
        private readonly IServiceScopeFactory _servicescopeFactory;

        public CitiesController(ICitiesService citiesService,
            ICitiesService citiesService1, ICitiesService citiesService2,
            IServiceScopeFactory servicescopeFactory)
        {
            //citiesService = new CitiesService();
            _citiesService = citiesService;
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _servicescopeFactory = servicescopeFactory;
            _servicescopeFactory = servicescopeFactory;
        }

        [Route("/")]
        public IActionResult Index()
        {
            List<string> cities = _citiesService.GetCities();

            ViewBag._citiesServiceId = _citiesService.ServiceInstanceId;
            ViewBag._citiesServiceId1 = _citiesService1.ServiceInstanceId;
            ViewBag._citiesServiceId2 = _citiesService2.ServiceInstanceId;

            using (IServiceScope scope = _servicescopeFactory.CreateScope())
            {
                //inject CitiesService, connect to DB
                ICitiesService citiesService = scope.ServiceProvider.GetRequiredService<ICitiesService>();
                //DB work

                ViewBag._citiesServiceId_InScope = citiesService.ServiceInstanceId;
            }
            //end of scope, it calls CitiesService.Dispose() automatically


            return View(cities);
        }
    }
}
