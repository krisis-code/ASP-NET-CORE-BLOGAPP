﻿using Blog.Data.Repositories.Abstractions;
using Blog.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Blog.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;
        public HomeController(ILogger<HomeController> logger , IArticleService articleService)
        {
            _logger = logger;
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index(Guid? categoryId, int currentPage = 1 , int pageSize = 3,bool isAscending = false)
        {
            var articles = await articleService.GetAllByPagingAsync(categoryId,currentPage,pageSize,isAscending);
            return View(articles);
        }
        public async Task<IActionResult> Search(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            var articles = await articleService.SearchAsync(keyword, currentPage, pageSize, isAscending);
            return View(articles);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}