using System.ComponentModel.DataAnnotations;

namespace Data.Entities;

public class WordAssociation : IEntityItem
{
    public int Id { get; set; }

    //public int? UserId { get; set; }
    //public User? User { get; set; }
    
    [Required]
    public int WordId { get; set; }
    public Word Word { get; set; } = null!;
    
    [Required]
    public int AssociationId { get; set; }
    public Association Association { get; set; } = null!;

    public List<UserWord> UserWords { get; set; } = new();

    public User User { get; set; } = null!;

    public int? UserId { get; set; }
}
