﻿using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var loggedInUser = await _userManager.GetUserAsync(HttpContext.User);
            var map = _mapper.Map<UserDto>(loggedInUser);
            var role = string.Join("", await _userManager.GetRolesAsync(loggedInUser));
            map.Role = role;
            return View(map);
        }
    }
}
