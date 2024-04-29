using Blog.Entity.DTOs.Articles;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IArticleService
    {

        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task<ArticleDto> GetArticlesWithCategoryNonDeletedAsync(Guid articleId);
        Task UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);

        Task SafeDeleteArticleAsync(Guid articleId);


    }
}
