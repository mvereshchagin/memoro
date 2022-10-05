using Data.Settings;

namespace Data.Services;

public interface ISettingsProvider
{
    public GeneralSettings Read();

    public void Update(GeneralSettings settings);
}