using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly WeatherService _weatherService;

        public HomeController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                ViewBag.Error = "Vui lòng nhập tên thành phố.";
                return View();
            }

            var weather = await _weatherService.GetWeatherAsync(city);
            if (weather == null)
            {
                ViewBag.Error = "Không tìm thấy thành phố này!";
                return View();
            }

            return View(weather); // Truyền dữ liệu sang View
        }
    }
}