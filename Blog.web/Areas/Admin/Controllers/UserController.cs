using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Areas.Admin.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
