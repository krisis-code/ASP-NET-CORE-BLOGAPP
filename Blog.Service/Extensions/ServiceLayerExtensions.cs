using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Blog.Data.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService,ArticleService>();
     
            return services;
        }
    }
}
