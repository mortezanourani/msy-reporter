using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class Champion
{
    [Key]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Gender { get; set; }

    public virtual ICollection<Championship>? Championships { get; set; }
}
