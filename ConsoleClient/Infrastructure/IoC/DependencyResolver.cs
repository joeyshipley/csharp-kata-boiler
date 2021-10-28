using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleClient.Infrastructure.IoC
{
    public static class DependencyResolver
    {
        private static IServiceProvider _serviceProvider;
        private static readonly Assembly[] AutoResolvedAssemblies = new []
        {
            Assembly.Load("ConsoleClient")
        };
                
        public static T Resolve<T>()
        {
            return Resolve<T>(new List<Action<IServiceCollection>>());
        }

        public static T Resolve<T>(List<Action<IServiceCollection>> registerResolverOverrides)
        {
            return (T) ServiceProvider(registerResolverOverrides).GetService(typeof(T));
        }
        
        private static IServiceProvider ServiceProvider(List<Action<IServiceCollection>> registerResolverOverrides)
        {
            var services = new ServiceCollection();
            RegisterStatelessDependencies(services);
            registerResolverOverrides.ForEach(register => register(services));
            _serviceProvider ??= services.BuildServiceProvider();
            return _serviceProvider;
        }        
        
        private static void RegisterStatelessDependencies(IServiceCollection services)
        {
            services.Scan(sc => sc
                .FromAssemblies(AutoResolvedAssemblies)
                .AddClasses()
                .AsImplementedInterfaces()
                .WithTransientLifetime()
            );
        }        
    }
}