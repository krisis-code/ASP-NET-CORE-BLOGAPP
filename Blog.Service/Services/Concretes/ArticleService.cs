﻿using Blog.Data.Repositories.Abstractions;
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
            var imageId = Guid.Parse("B93E0A19-EA35-4121-985A-5D2E33720DE4");

            var article = new Article(articleAddDto.Title, articleAddDto.Content, userId,articleAddDto.CategoryId ,imageId);
          
            await unitOfWork.GetRepository<Article>().addAsync(article);
            await unitOfWork.SaveAsync();


        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x=>!x.IsDeleted,x =>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);
            return map;
        }

        public async Task<ArticleDto> GetArticlesWithCategoryNonDeletedAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id==articleId, x => x.Category);
            var map = mapper.Map<ArticleDto>(article);
            return map;
        }

        public async Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
        {
            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.Category);
           article.Title = articleUpdateDto.Title;
            article.Content = articleUpdateDto.Content;
            article.CategoryId = articleUpdateDto.CategoryId;
            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();
            
        }

        public async Task SafeDeleteArticleAsync(Guid articleId)
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId);
            article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
            await unitOfWork.SaveAsync();   


        }
    }
}
