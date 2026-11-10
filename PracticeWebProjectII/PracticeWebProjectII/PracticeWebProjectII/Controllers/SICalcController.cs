using Microsoft.AspNetCore.Mvc;
using PracticeWebProjectII.Models;

namespace PracticeWebProjectII.Controllers
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
        [ValidateAntiForgeryToken]
        public IActionResult Index(SI model)
        {
            if (model == null)
            {
                model = new SI();
            }

            // Simple Interest = (Principal * Rate * Time) / 100
            double result = model.principal * model.rate * model.time / 100.0;
            ViewData["Result"] = result;

            return View(model);
        }
    }
}
