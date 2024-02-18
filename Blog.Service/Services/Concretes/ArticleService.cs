using Blog.Data.Repositories.Abstractions;
using Blog.Entity.Entities;

namespace Blog.Data.Repositories.Concretes
{
    public class ArticleService : IArticleService
    {
        public Task<List<Article>> GetAllArticlesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
