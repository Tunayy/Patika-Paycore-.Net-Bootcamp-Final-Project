using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PycApi.Mapper;
using PycApi.Service;
using StackExchange.Redis;
using System;

namespace PycApi.StartUpExtension
{
    public static class ExtensionService
    {
       

        public static void AddServices(this IServiceCollection services)
        {
            // services 
            services.AddScoped<ICategory_Service,Category_Service>();
            services.AddScoped<IProduct_Service, Product_Service>();
            services.AddScoped<IAccount_Service, Account_Service>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IEmail_Service, Email_Service>();
            services.AddScoped<IAuth_Service, Auth_Service>();

            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
