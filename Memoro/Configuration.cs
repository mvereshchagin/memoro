using Data.Repositories;
using Data.Entities;
using Providers.Repositories;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Providers.Settings;

namespace Memoro;

internal static class Configuration
{
    public static Container Container { get; private set; }

    public static void Init()
    {
        // 1. Create a new Simple Injector container
        Container = new Container();

        string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.ini");
        var settingProvider = new SettingsProvider(configPath);

        var settings = settingProvider.Read();
        var connectionString = settings.ConnectionString;

        // 2. Configure the container (register)
        // See below for more configuration examples
        Container.Register<IUserRepository>(() => new UserRepository(connectionString));
        Container.Register<IUserWordAssociationRepository>(() => new UserWordAssociationRepository(connectionString));
        Container.Register<IWordRepository>(() => new WordRepository(connectionString));
        Container.Register<IAssociationRepository>(() => new AssociationRepository(connectionString));
        Container.Register<ISettingsProvider>(() => new SettingsProvider(configPath));

        // 3. Verify the container's configuration.
        Container.Verify();


        //// 4. Store the container for use by the application
        //DependencyResolver.SetResolver(
        //    new SimpleInjectorDependencyResolver(container));

    }





    

}   
