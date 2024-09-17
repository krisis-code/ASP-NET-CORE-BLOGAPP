using AutoMapper;
using Blog.Data.Mappings;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Helpers.Image;
using Blog.Service.Services.Abstractions;
using Blog.web.Areas.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blog.web.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class UserController : Controller
	{
		private readonly UserManager<AppUser> userManager;
        private readonly IUserService userService;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IImageHelper imageHelper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IValidator<AppUser> validator;
		private readonly IToastNotification toastNotification;
		private readonly RoleManager<AppRole> roleManager;
		private readonly IMapper mapper;

		public UserController(UserManager<AppUser> userManager,IUserService userService, IValidator<AppUser> validator, IToastNotification toastNotification, RoleManager<AppRole> roleManager, IMapper mapper, SignInManager<AppUser> signInManager, IImageHelper imageHelper, IUnitOfWork unitOfWork)
		{
			this.userManager = userManager;
            this.userService = userService;
            this.validator = validator;
			this.toastNotification = toastNotification;
			this.roleManager = roleManager;
			this.mapper = mapper;
			this.signInManager = signInManager;
            this.imageHelper = imageHelper;
            this.unitOfWork = unitOfWork;
        }
		public async Task<IActionResult> Index()
		{
			return View(await userService.GetAllUserWithRoleAsync());
		}
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var roles = await userService.GetAllRolesAsync();
			return View(new UserAddDto { Roles = roles });
		}
		[HttpPost]
		public async Task<IActionResult> Add(UserAddDto userAddDto)
		{
			var map = mapper.Map<AppUser>(userAddDto);
			var validation = await validator.ValidateAsync(map);
			var roles = await userService.GetAllRolesAsync();
            if (ModelState.IsValid)
			{
				var result = await userService.CreateUserAsync(userAddDto);
				if (result.Succeeded)
				{
					
					toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = "Başarılı"! });
					return RedirectToAction("Index", "User", new { area = "Admin" });
				}
				else
				{
					
					result.AddToIdentityModelState(this.ModelState);
					validation.AddToModelState(this.ModelState);
					return View(new UserAddDto { Roles = roles });
				}
			}
			return View(new UserAddDto { Roles = roles });

		}

		[HttpGet]
		public async Task<IActionResult> Update(Guid userId)
		{
			var user = await userService.GetAppUserByIdAsync(userId);

			var roles = await userService.GetAllRolesAsync();

			var map = mapper.Map<UserUpdateDto>(user);
			map.Roles = roles;

			return View(map);

		}
		[HttpPost]
		public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
		{
			var user = await userService.GetAppUserByIdAsync(userUpdateDto.Id);

			if (user != null)
			{
				var userRole = await userService.GetUserRoleAsync(user);
				var roles = await userService.GetAllRolesAsync();
				if (ModelState.IsValid)
				{
					var map = mapper.Map(userUpdateDto, user);
					var validation = await validator.ValidateAsync(map);
					if (validation.IsValid)
					{
						user.UserName = userUpdateDto.Email;
						user.SecurityStamp = Guid.NewGuid().ToString();
						var result = await userService.UpdateUserAsync(userUpdateDto);
						if (result.Succeeded)
						{
							toastNotification.AddSuccessToastMessage(Messages.User.Update(userUpdateDto.Email), new ToastrOptions { Title = "Başarılı"! });
							return RedirectToAction("Index", "User", new { area = "Admin" });
						}
						else
						{
							result.AddToIdentityModelState(this.ModelState);
							return View(new UserUpdateDto { Roles = roles });
						}
					}
					else
					{

						validation.AddToModelState(this.ModelState);
						return View(new UserUpdateDto { Roles = roles });

					}

				}


			}
			return NotFound();


		}

		public async Task<IActionResult> Delete(Guid userId)
		{
			
			var result = await userService.DeleteUserAsync(userId);
			if (result.identityResult.Succeeded)
			{
				toastNotification.AddSuccessToastMessage(Messages.User.Delete(result.email), new ToastrOptions { Title = "Başarılı"! });
				return RedirectToAction("Index", "User", new { area = "Admin" });
			}
			else
			{

				result.identityResult.AddToIdentityModelState(this.ModelState);

			}
			return NotFound();


		}

		[HttpGet]
		public async Task<IActionResult> Profile()
		{
			var profile = await userService.GetUserProfileAsync();
			return View(profile);
		}

		[HttpPost]
		public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
		{
			var user = await userManager.GetUserAsync(HttpContext.User);

			if (ModelState.IsValid)
			{
				var result = await userService.UserProfileUpdateAsync(userProfileDto);
				if (result)
				{
					toastNotification.AddSuccessToastMessage("Profil güncelleme işlemi başarılı", new ToastrOptions { Title = "İşlem Başarılı" });
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
				else
				{
					var profile = await userService.GetUserProfileAsync();
                    toastNotification.AddErrorToastMessage("Profil güncelleme işlemi başarısız", new ToastrOptions { Title = "İşlem Başarısız" });
                    return View(profile);
                }
			}
			else
				return NotFound();
        }


	}
}

