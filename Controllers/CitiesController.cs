using Autofac;
using LearningScripts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ServiceContracts;

namespace LearningScripts.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ICitiesService _citiesService;
        private readonly ICitiesService _citiesService1;
        private readonly ICitiesService _citiesService2;
        private readonly ILifetimeScope _lifeTimeScope;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        private readonly ApiOptions _apiOptions;

        public CitiesController(ICitiesService citiesService,
            ICitiesService citiesService1, ICitiesService citiesService2,
            ILifetimeScope servicescopeFactory,
            IWebHostEnvironment webHostEnvironment, IConfiguration configuration,
            IOptions<ApiOptions> apioptions)
        {
            //citiesService = new CitiesService();
            _citiesService = citiesService;
            _citiesService1 = citiesService1;
            _citiesService2 = citiesService2;
            _lifeTimeScope = servicescopeFactory;
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
            _apiOptions = apioptions.Value;
        }

        [Route("/cities")]
        public IActionResult Index()
        {
            /*ApiOptions? options = _configuration.GetSection("API").Get<ApiOptions>();
            ViewBag.ClientID = options.ClientID;
            ViewBag.ClientSecret = options.ClientSecret;*/

            //ViewBag.ClientID = _configuration["API:ClientID"];
            //ViewBag.ClientID = _configuration.GetSection("API")["ClientID"];
            //ViewBag.ClientSecret = _configuration.GetValue("API:ClientSecret", "The Default");

            ViewBag.ClientID = _apiOptions.ClientID;
            ViewBag.ClientSecret = _apiOptions.ClientSecret;

            ViewBag.CurrentEnvironment = _webHostEnvironment.EnvironmentName;

            List<string> cities = _citiesService.GetCities();

            ViewBag._citiesServiceId = _citiesService.ServiceInstanceId;
            ViewBag._citiesServiceId1 = _citiesService1.ServiceInstanceId;
            ViewBag._citiesServiceId2 = _citiesService2.ServiceInstanceId;

            using (var scope = _lifeTimeScope.BeginLifetimeScope())
            {
                //inject CitiesService, connect to DB
                ICitiesService citiesService = scope.Resolve<ICitiesService>();
                //DB work

                ViewBag._citiesServiceId_InScope = citiesService.ServiceInstanceId;
            }
            //end of scope, it calls CitiesService.Dispose() automatically


            return View(cities);
        }
    }
}
