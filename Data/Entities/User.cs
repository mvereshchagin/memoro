using System.ComponentModel.DataAnnotations;

namespace Data.Entities;


public class User : IEntityItem
{
    public int Id { get; set; }
    
    [Required, MaxLength(32)]
    public string Login { get; set; } = null!;

    [Required, MaxLength(32)]
    public string Password { get; set; } = null!;
    
    [MaxLength(128)]
    public string? Name { get; set; }
    
    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public List<Word> Words { get; set; } = new();
    
    public List<UserWord> UserWords { get; set; } = new();

    public List<WordAssociation> WordAssociations { get; set; } = new();

    public List<Association> Associations { get; set; } = new();
}