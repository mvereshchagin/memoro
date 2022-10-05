using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class UserWord : IEntityItem
{
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    
    [Required]
    public int WordId { get; set; }
    public Word Word { get; set; } = null!;
    
    public int? WordAssociationId { get; set; }
    public WordAssociation? WordAssociation { get; set; }
    
    public WordStatus Status { get; set; }
}