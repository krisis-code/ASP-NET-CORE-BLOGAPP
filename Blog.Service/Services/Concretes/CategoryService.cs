using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Blog.Service.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
         
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);
            return map;

        }
        public async Task CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
          
            var userEmail = _user.GetLoggedInUserEmail();
            Category category = new(categoryAddDto.Name,userEmail);
            await unitOfWork.GetRepository<Category>().addAsync(category);
            await unitOfWork.SaveAsync();

           
        }
        public async Task<Category> GetCategoryByGuid(Guid id)
        {
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(id);

            return category;
        }

        public async Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto)
        {

            var userEmail = _user.GetLoggedInUserEmail();
            var category = await unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdateDto.Id);

            category.Name = categoryUpdateDto.Name;
            category.ModifiedBy = userEmail;
            category.ModifiedDate = DateTime.Now;


            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();


            return category.Name;


        }
    }

       
    
}
