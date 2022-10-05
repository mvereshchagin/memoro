namespace Data.Settings;

public class GeneralSettings
{
    public int? UserId { get; set; }

    public string ConnectionString { get; set; } = null!;
    
    public int WordsToLearn { get; set; }
    
    public int WordsToCheck { get; set; }
}