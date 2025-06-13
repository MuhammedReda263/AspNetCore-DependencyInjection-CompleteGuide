
using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using Services;
using System.Diagnostics;

namespace DIExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IcitiesService _citiesService1; 
        private readonly IcitiesService _citiesService2; 
        private readonly IcitiesService _citiesService3;
        public HomeController(ILogger<HomeController> logger, IcitiesService icitiesService1, IcitiesService icitiesService2, IcitiesService icitiesService3)
        {
            _logger = logger;
            _citiesService1 = icitiesService1;
            _citiesService2 = icitiesService2;
            _citiesService3 = icitiesService3;
        }
        [Route("/")]
        public IActionResult Index(/*[FromServices] IcitiesService icitiesService*/)
        {
            List<string> cities = _citiesService1.GetCities();
            ViewBag.instance1 = _citiesService1._guid;
            ViewBag.instance2 = _citiesService2._guid;
            ViewBag.instance3 = _citiesService3._guid;
            return View(cities);
        }

        
    }
}
