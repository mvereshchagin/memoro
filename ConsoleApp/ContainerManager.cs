using Data.Repositories;
using Data.Services;
using Providers.Repositories;
using Providers.Services;
using SimpleInjector;

namespace ConsoleApp;

public class ContainerManager
{
    private static readonly Lazy<Container> _container = new(ConfigureServices);
    
    private static Container ConfigureServices()
    {
        var container = new Container();
        
        var settingProvider = new SettingsProvider("appsettings.json");
        var settings = settingProvider.Read();
        var connectionString = settings.ConnectionString;
        
        container.Register<ISettingsProvider>(() =>
            settingProvider, Lifestyle.Transient);

        container.Register<IUserManager>(() =>
            new UserManager(settingProvider), Lifestyle.Transient);
        
        container.Register<IUserRepository>(() => 
            new UserRepository(connectionString), Lifestyle.Transient);
        container.Register<IWordRepository>(() => 
            new WordRepository(connectionString), Lifestyle.Transient);
        container.Register<IUserWordRepository>(() => 
            new UserWordRepository(connectionString), Lifestyle.Transient);
        container.Register<IAssociationRepository>(() => 
            new AssociationRepository(connectionString), Lifestyle.Transient);

        container.Verify();

        return container;
    }
    
    public static Container Instance => _container.Value;
}