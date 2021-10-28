using System;
using System.Collections.Generic;
using ConsoleClient.Infrastructure.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Tests.Infrastructure
{
    public class ComponentTestFor<T> : ArrangeActAssertOn
    {
        protected readonly List<Action<IServiceCollection>> DependencyFakes = new List<Action<IServiceCollection>>();

        protected T SUT;

        public ComponentTestFor()
        {
            SharedBeforeAll();
        }

        protected TResolveFor Resolve<TResolveFor>()
        {
            return DependencyResolver.Resolve<TResolveFor>(DependencyFakes);
        }

        private void SharedBeforeAll()
        {
            DependencyFakes.Add((services) => 
            {
            });
            SUT = Resolve<T>();
        }
    }
}