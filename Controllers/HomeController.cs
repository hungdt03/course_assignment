using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using test_course.DBContext;
using test_course.ViewModels;

namespace test_course.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int? khoaHocId)
        {
            var khoahocs = await context.KhoaHoc.ToListAsync();
            if (khoaHocId == null)
            {
                khoaHocId = khoahocs[0].Id;
            }

            var monHocs = await context.MonHoc
                .Where(m => m.KhoaHocID == khoaHocId)
                .ToListAsync();

            var viewModel = new KhoaHocViewModel
            {
                KhoaHocs = khoahocs,
                MonHocs = monHocs
            };
            
            return View(viewModel);
        }

    }
}
