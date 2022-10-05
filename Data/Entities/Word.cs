using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Word : IEntityItem
{
    public int Id { get; set; }
    
    [Required, MaxLength(128)]
    public string Text { get; set; } = null!;
    
    [MaxLength(128)]
    public string? Transcription { get; set; }
    
    [MaxLength(1024)]
    public string? Translation { get; set; }

    public List<Association> Associations { get; set; } = new();

    public List<WordAssociation> WordAssociations { get; set; } = new();

    public List<User> Users { get; set; } = new();

    public List<UserWord> UserWords { get; set; } = new();
}
