using StructureMap;
using WebSite.Services;
using WebSite.Models;
using WebSite.Data;

namespace Site
{//structure map
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDatabaseFactory>().Use<DatabaseFactory>();
                            x.For<IUnitOfWork>().Use<UnitOfWork>();
                            x.For<ISiteSettingsRepository>().Use<SiteSettingsRepository>();
                            x.For<ICategoryRepository>().Use<CategoryRepository>();
                            x.For<ISettingsService>().Use<SettingsService>();
                            x.For<IPostsRepository>().Use<PostsRepository>();
                            x.For<ISectionsRepository>().Use<SectionsRepository>();
                            x.For<ISectionsService>().Use<SectionsService>();
                            x.For<ICategoryService>().Use<CategoryService>();
                        });
            return ObjectFactory.Container;
        }
    }
}//x.For<IExample>().Use<Example>();