using System;
using Microsoft.Practices.Unity;
using RepositoryDemo.Repository;
using RepositoryDemo.Data;
using System.Web.Mvc;
using Microsoft.Practices.Unity.Mvc;

namespace RepositoryDemo.Web.App_Start
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // Register your types here
            container.RegisterType<IRepository<Customer, string>, CustomerRepository>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
