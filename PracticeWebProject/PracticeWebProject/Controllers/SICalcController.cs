using Microsoft.AspNetCore.Mvc;
using PracticeWebProject.Models;

namespace PracticeWebProject.Controllers
{
    public class SICalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            SI obj = new SI();
            return View(obj);
        }
        
        [HttpPost]
        public IActionResult Index(SI obj)
        {
            double si = (obj._p * obj._r * obj._t) / 100;

            return View();
        }

    }
}