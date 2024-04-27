using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
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
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
