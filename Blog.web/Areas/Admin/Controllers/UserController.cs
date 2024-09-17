using AutoMapper;
using Blog.Data.Mappings;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.web.Areas.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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
		private readonly SignInManager<AppUser> signInManager;
		private readonly IValidator<AppUser> validator;
		private readonly IToastNotification toastNotification;
		private readonly RoleManager<AppRole> roleManager;
		private readonly IMapper mapper;

		public UserController(UserManager<AppUser> userManager, IValidator<AppUser> validator, IToastNotification toastNotification, RoleManager<AppRole> roleManager, IMapper mapper, SignInManager<AppUser> signInManager)
		{
			this.userManager = userManager;
			this.validator = validator;
			this.toastNotification = toastNotification;
			this.roleManager = roleManager;
			this.mapper = mapper;
			this.signInManager = signInManager;
		}
		public async Task<IActionResult> Index()
		{
			var users = await userManager.Users.ToListAsync();
			var map = mapper.Map<List<UserDto>>(users);

			foreach (var item in map)
			{
				var findUser = await userManager.FindByIdAsync(item.Id.ToString());
				var role = string.Join("", await userManager.GetRolesAsync(findUser));
				item.Role = role;

			}

			return View(map);
		}
		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var roles = await roleManager.Roles.ToListAsync();
			return View(new UserAddDto { Roles = roles });
		}
		[HttpPost]
		public async Task<IActionResult> Add(UserAddDto userAddDto)
		{
			var map = mapper.Map<AppUser>(userAddDto);
			var validation = await validator.ValidateAsync(map);
			var roles = await roleManager.Roles.ToListAsync();
			if (ModelState.IsValid)
			{
				map.UserName = userAddDto.Email;
				var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
				if (result.Succeeded)
				{
					var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
					await userManager.AddToRoleAsync(map, findRole.ToString());
					toastNotification.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = "Başarılı"! });
					return RedirectToAction("Index", "User", new { area = "Admin" });
				}
				else
				{
					//            foreach (var errors in result.Errors)
					//ModelState.AddModelError("",errors.Description);
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
			var user = await userManager.FindByIdAsync(userId.ToString());

			var roles = await roleManager.Roles.ToListAsync();

			var map = mapper.Map<UserUpdateDto>(user);
			map.Roles = roles;

			return View(map);

		}
		[HttpPost]
		public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
		{
			var user = await userManager.FindByIdAsync(userUpdateDto.Id.ToString());

			if (user != null)
			{
				var userRole = string.Join("", await userManager.GetRolesAsync(user));
				var roles = await roleManager.Roles.ToListAsync();
				if (ModelState.IsValid)
				{
					var map = mapper.Map(userUpdateDto, user);
					var validation = await validator.ValidateAsync(map);
					if (validation.IsValid)
					{
						user.UserName = userUpdateDto.Email;
						user.SecurityStamp = Guid.NewGuid().ToString();
						var result = await userManager.UpdateAsync(user);
						if (result.Succeeded)
						{
							await userManager.RemoveFromRoleAsync(user, userRole);
							var findRole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
							await userManager.AddToRoleAsync(user, findRole.Name);
							toastNotification.AddSuccessToastMessage(Messages.User.Update(userUpdateDto.Email), new ToastrOptions { Title = "Başarılı"! });
							return RedirectToAction("Index", "User", new { area = "Admin" });
						}
						else
						{
							result.AddToIdentityModelState(this.ModelState);
							//ModelState.AddModelError("", errors.Description);

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
			var user = await userManager.FindByIdAsync(userId.ToString());
			var result = await userManager.DeleteAsync(user);
			if (result.Succeeded)
			{
				toastNotification.AddSuccessToastMessage(Messages.User.Delete(user.Email), new ToastrOptions { Title = "Başarılı"! });
				return RedirectToAction("Index", "User", new { area = "Admin" });
			}
			else
			{

				result.AddToIdentityModelState(this.ModelState);

			}
			return NotFound();


		}

		[HttpGet]
		public async Task<IActionResult> Profile()
		{
			var user = await userManager.GetUserAsync(HttpContext.User);
			var map = mapper.Map<UserProfileDto>(user);
			return View(map);
		}

		[HttpPost]
		public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
		{
			var user = await userManager.GetUserAsync(HttpContext.User);

			if (ModelState.IsValid)
			{
				var isVerified = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);
				if (isVerified && userProfileDto.NewPassword != null)
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
						await userManager.UpdateAsync(user);
						toastNotification.AddSuccessToastMessage("Şifreniz ve bilgileriniz başarıyla değiştirilmiştir.");
						return View();


					}
					else
						result.AddToIdentityModelState(ModelState); return View();

				}
				else if (isVerified)
				{
                    await userManager.UpdateSecurityStampAsync(user);
                    user.FirstName = userProfileDto.FirstName;
                    user.LastName = userProfileDto.LastName;
                    user.PhoneNumber = userProfileDto.PhoneNumber;
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

