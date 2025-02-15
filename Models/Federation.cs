using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reporter.Models;

public class Federation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public virtual City? City { get; set; }

    public string Name { get; set; }

    public string? UniqueId { get; set; }

    public string? Address { get; set; }
}
