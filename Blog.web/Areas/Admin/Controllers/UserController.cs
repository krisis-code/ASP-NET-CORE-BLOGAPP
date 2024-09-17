﻿using AutoMapper;
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
			var user = await userManager.GetUserAsync(HttpContext.User);
			var getImage = await unitOfWork.GetRepository<AppUser>().GetAsync(x => x.Id == user.Id,x =>x.Image);
			var map = mapper.Map<UserProfileDto>(user);
			map.Image.FileName = getImage.Image.FileName;
			return View(map);
		}

		[HttpPost]
		public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
		{
			var user = await userManager.GetUserAsync(HttpContext.User);

			if (ModelState.IsValid)
			{
				var isVerified = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);
				if (isVerified && userProfileDto.NewPassword != null && userProfileDto.Photo != null)
				{
					var result = await userManager.ChangePasswordAsync(user, userProfileDto.CurrentPassword, userProfileDto.NewPassword);

					if (result.Succeeded)
					{
						await userManager.UpdateSecurityStampAsync(user);
						await signInManager.SignOutAsync();
						await signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);
						user.FirstName = userProfileDto.FirstName;
						user.LastName = userProfileDto.LastName;
						user.PhoneNumber = userProfileDto.PhoneNumber;
						var imageUpload = await imageHelper.Upload($"{  userProfileDto.FirstName} {userProfileDto.LastName}",userProfileDto.Photo, ImageType.User);
                        Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, userProfileDto.Email);
                        await unitOfWork.GetRepository<Image>().addAsync(image);

                        await userManager.UpdateAsync(user);
						toastNotification.AddSuccessToastMessage("Şifreniz ve bilgileriniz başarıyla değiştirilmiştir.");
						return View();


					}
					else
						result.AddToIdentityModelState(ModelState); return View();

				}
				else if (isVerified && userProfileDto.Photo != null)
				{
                    await userManager.UpdateSecurityStampAsync(user);
                    user.FirstName = userProfileDto.FirstName;
                    user.LastName = userProfileDto.LastName;
                    user.PhoneNumber = userProfileDto.PhoneNumber;
                    var imageUpload = await imageHelper.Upload($"{userProfileDto.FirstName} {userProfileDto.LastName}", userProfileDto.Photo, ImageType.User);
                    Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, userProfileDto.Email);
                    await unitOfWork.GetRepository<Image>().addAsync(image);
                    await userManager.UpdateAsync(user);
                    toastNotification.AddSuccessToastMessage("Bilgileriniz başarıyla değiştirilmiştir.");
					return View();

                }
				else
                    toastNotification.AddErrorToastMessage("Bilgileriniz güncellenirken  hata oluştur."); return View();

               
			}

            return View();
        }


	}
}

