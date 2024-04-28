using Blog.Entity.DTOs.Articles;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IArticleService
    {

        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task GetArticlesWithCategoryNonDeletedAsync(ArticleUpdateDto articleUpdateDto);
    }
}
