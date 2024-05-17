using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		public async Task  <IActionResult> Index()
		{
			return View();
		}
	}
}
