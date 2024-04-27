using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using AutoMapper;

namespace Blog.Data.Repositories.Concretes
{
    
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork , IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("CB94223B-CCB8-4F2F-93D7-0DF96A7F065C");

            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                UserId = userId
            };
            await unitOfWork.GetRepository<Article>().addAsync(article);
            await unitOfWork.SaveAsync();


        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted,x =>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}
