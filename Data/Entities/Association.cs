using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class Association : IEntityItem
{
    public int Id { get; set; }

    [MaxLength(256)]
    public string? Text { get; set; }
    
    public byte[]? Image { get; set; }

    public List<Word> Words { get; set; } = new();

    public List<WordAssociation> WordAssociations { get; set; } = new();

    //public List<User> Users { get; set; } = new();
}
