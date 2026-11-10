using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeWebProject.Models;

namespace PracticeWebProject.Pages.SI
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PracticeWebProject.Models.SI Input { get; set; }

        public double? Result { get; set; }

        public void OnGet()
        {
            Input = new PracticeWebProject.Models.SI();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Result = (Input._p * Input._r * Input._t) / 100.0;
            ViewData["Result"] = Result;
            return Page();
        }
    }
}
