using System.Text.Json;
using System.Text.Json.Serialization;
using Data.Repositories;
using Data.Services;
using Data.Settings;
using Microsoft.Extensions.Configuration;

namespace Providers.Services;

public class SettingsProvider : ISettingsProvider
{
    private readonly string _fileName;
    private readonly IConfigurationRoot _config;
    
    public SettingsProvider(string path)
    {
        _fileName = path;
        
        _config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile(_fileName)
            .Build();
    }
    
    public GeneralSettings Read()
    {
        var settings = _config.Get<GeneralSettings>();
        if (settings is null)
            throw new ArgumentException();

        return settings;
    }

    public void Update(GeneralSettings settings)
    {
        var jsonWriteOptions = new JsonSerializerOptions()
        {
            WriteIndented = true
        };
        jsonWriteOptions.Converters.Add(new JsonStringEnumConverter());

        var newJson = JsonSerializer.Serialize(settings, jsonWriteOptions);
        
        var appSettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileName);
        File.WriteAllText(appSettingsPath, newJson);
    }
}