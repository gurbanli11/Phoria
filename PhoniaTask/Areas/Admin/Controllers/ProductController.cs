using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhoniaTask.DAL;

namespace PhoniaTask.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(ProniaContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }
    }
}
