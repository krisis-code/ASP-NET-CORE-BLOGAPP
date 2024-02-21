using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Blog.Data.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService,ArticleService>();
     
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
