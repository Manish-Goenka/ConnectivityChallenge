using System;
using System.Reflection;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectivityChallenge.UT
{
    public abstract class BaseSetup
    {
        private static IServiceCollection Services => ConfigureScope(new ServiceCollection());

        private static IServiceCollection ConfigureScope(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load("ConnectivityChallenge.BLL"), Assembly.GetExecutingAssembly());

            return services;
        }

        public static ServiceProvider ServiceProvider => Services.BuildServiceProvider();

        public static IMapper Mapper => ServiceProvider.GetRequiredService<AutoMapper.IMapper>();

        public static T GetService<T>()
        {
            return ServiceProvider.GetService<T>();
        }
    }
}