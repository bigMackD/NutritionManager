using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NutritionManager.Data.Models;
using NutritionManager.Data.Repositories;

namespace NutritionManager.Data.Controllers
{
    public class HomeController : Controller
    {
        private IUsersRepository _users;
        public HomeController(IUsersRepository users)
        {
            _users = users;
        }
        public IActionResult Index()
        {
            var user = _users.GetUser(1);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
