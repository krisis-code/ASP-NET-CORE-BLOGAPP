using Blog.Entity.Entities;
using System.Linq.Expressions;

namespace Blog.Data.Repositories.Abstractions
{
    public interface IArticleService
    {

        Task<List<Article>> GetAllArticlesAsync();

    }
}
