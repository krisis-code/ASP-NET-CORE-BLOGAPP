using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;
using System.Reflection;
using Blog.Service.FluentValidations;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Blog.Service.Helpers.Image;

namespace Blog.Data.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddScoped<IArticleService,ArticleService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IImageHelper, ImageHelper>();
            services.AddAutoMapper(assembly);

            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");


            });
            return services;
        }
    }
}
