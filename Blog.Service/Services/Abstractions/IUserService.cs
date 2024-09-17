using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUserWithRoleAsync();

        Task<List<AppRole>> GetAllRolesAsync();

        Task<IdentityResult> CreateUserAsync(UserAddDto userAddDto);

        Task<AppUser> GetAppUserByIdAsync(Guid userId);
    }
}
