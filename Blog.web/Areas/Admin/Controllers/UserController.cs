using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blog.web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly UserManager<AppUser> userManager;

		public UserController(UserManager<AppUser> userManager)
        {
			this.userManager = userManager;
		}
        public async Task  <IActionResult> Index()
		{
			var users = await userManager.Users.ToListAsync();
			return View();
		}
	}
}
