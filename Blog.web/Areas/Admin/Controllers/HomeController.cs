using Blog.Data.Repositories.Abstractions;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashboardService dashboardService;
        public HomeController(IArticleService articleService, IDashboardService dashboardService)
        {
            this.articleService = articleService;
            this.dashboardService = dashboardService;
        }
        public  async Task<IActionResult> Index( )
        {
            var articles = await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
          
            return View(articles);
        }
        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await  dashboardService.GetYearlyArticleCountes();
            return Json(JsonConvert.SerializeObject(count));
        }
        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashboardService.GetTotalArticleCountes();
            return Json(count);
        }
    }
}
