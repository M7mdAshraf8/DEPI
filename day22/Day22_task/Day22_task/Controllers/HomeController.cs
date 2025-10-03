using System.Diagnostics;
using Day22_task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day22_task.Controllers
{
    public class HomeController : Controller
    {
        public ContentResult ShowMsg()
        {
            return Content("Hello Mohamed Ashraf");

        }
        public ViewResult ShowView()
        {
            return View("Details");
        }
        public IActionResult ShowById(int id)
        {
            ViewData["Message"] = $"You have entered ID = {id}";
            ViewData["Squared"] = id * id; 
            return View("ShowById");
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
