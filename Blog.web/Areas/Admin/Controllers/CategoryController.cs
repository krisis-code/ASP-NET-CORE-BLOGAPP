using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
