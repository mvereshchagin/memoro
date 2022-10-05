using Data.Entities;
using Data.Repositories;
using Data.Services;

namespace Providers.Services;

public class UserManager : IUserManager
{
    private readonly SettingsProvider _settingsProvider;
    
    public UserManager(SettingsProvider settingsProvider)
    {
        _settingsProvider = settingsProvider;
    }
    
    public void SignIn(User user)
    {
        var settings = _settingsProvider.Read();
        settings.UserId = user.Id;
        _settingsProvider.Update(settings);
    }

    public void SignOut()
    {
        var settings = _settingsProvider.Read();
        settings.UserId = null;
        _settingsProvider.Update(settings);
    }

    public int? UserId
    {
        get
        {
            var settings = _settingsProvider.Read();
            return settings.UserId;
        }
    }

    public bool IsAuthenticated => this.UserId is not null;
}