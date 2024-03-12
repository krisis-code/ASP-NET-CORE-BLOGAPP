using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
