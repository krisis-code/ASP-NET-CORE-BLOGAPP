﻿using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concretes
{
    
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserService(IUnitOfWork unitOfWork,IMapper mapper,UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto)
        {
            var map = _mapper.Map<AppUser>(userAddDto);
            map.UserName = userAddDto.Email;
            var result = await _userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
            if (result.Succeeded)
            {
                var findRole = await _roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                await _userManager.AddToRoleAsync(map, findRole.ToString());
                return result;
            }
            else
                return result;
        }

        public async Task<(IdentityResult identityResult, string? email)> DeleteUserAsync(Guid userId)
        {
            var user = await GetAppUserByIdAsync(userId);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded) 
               return (result,user.Email);
            else
                return (result,null);
        }

        public async Task<List<AppRole>> GetAllRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

        public async Task<List<UserDto>> GetAllUserWithRoleAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var map = _mapper.Map<List<UserDto>>(users);

            foreach (var item in map)
            {
                var findUser = await _userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await _userManager.GetRolesAsync(findUser));
                item.Role = role;

            }

            return map;
        }

        public async Task<AppUser> GetAppUserByIdAsync(Guid userId)
        {
            return await _userManager.FindByIdAsync(userId.ToString());
        }

        public async Task<string> GetUserRoleAsync(AppUser user)
        {
            return string.Join("", await _userManager.GetRolesAsync(user));
        }

        public async Task<IdentityResult> UpdateUserAsync(UserUpdateDto userUpdateDto)
        {
            var user = await GetAppUserByIdAsync(userUpdateDto.Id);
            var userRole = await GetUserRoleAsync(user);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                await _userManager.RemoveFromRoleAsync(user, userRole);
                var findRole = await _roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                await _userManager.AddToRoleAsync(user, findRole.Name);
                return result;
            }
            else
                return result;
        }
    }
}
