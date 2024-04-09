using Microsoft.AspNetCore.Mvc;
using Rating.Models;
using System.Diagnostics;

namespace Rating.Controllers
{
    public class InsuranceController : Controller
    {
        private readonly ILogger<InsuranceController> _logger;

        public InsuranceController(ILogger<InsuranceController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clients()
        {
            return View();
        }
        public IActionResult Trap()
        {
            return View();
        }
        [HttpPost]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
