using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using WebSite.Data;
using WebSite.Services;


namespace Site
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            container
                .RegisterType<IDatabaseFactory, DatabaseFactory>(new HierarchicalLifetimeManager())
                .RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager())
                .RegisterType<ISiteSettingsRepository, SiteSettingsRepository>(new HierarchicalLifetimeManager())
                .RegisterType<ICategoryRepository, CategoryRepository>(new HierarchicalLifetimeManager())
                .RegisterType<ISettingsService, SettingsService>(new HierarchicalLifetimeManager())
                .RegisterType<ITopicsRepository, TopicsRepository>(new HierarchicalLifetimeManager())
                .RegisterType<ISectionsRepository, SectionsRepository>(new HierarchicalLifetimeManager())
                .RegisterType<ISectionsService, SectionsService>(new HierarchicalLifetimeManager());

            container.RegisterControllers();

            return container;
        }
    }
}