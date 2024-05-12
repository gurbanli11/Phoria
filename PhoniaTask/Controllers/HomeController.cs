using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoniaTask.DAL;
using PhoniaTask.ViewModels.Categories;
using PhoniaTask.ViewModels.Sliders;

namespace PhoniaTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly PhoniaContext _context;

        public HomeController(PhoniaContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var data = await _context.Sliders
                 .Where(x => !x.IsDeleted)
                 .Select(s => new GetSliderVM
                 {
                     Discount = s.Discount,
                     Id = s.Id,
                     ImageUrl = s.ImageUrl,
                     Title = s.Title,
                     Subtitle = s.Subtitle
                 }).ToListAsync();
            return View(data);
        }
    }
}
