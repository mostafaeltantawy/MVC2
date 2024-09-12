using Microsoft.AspNetCore.Mvc;

namespace MVC2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] // GET baseURL/Home/Index
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet] // GET baseURL/Home/Index
        public IActionResult AboutUs()
        {
            return View();
        }
        [HttpGet] // GET baseURL/Home/Index
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet] // GET baseURL/Home/Index
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
