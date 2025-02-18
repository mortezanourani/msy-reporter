using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class Championship
{
    [Key]
    public Guid Id { get; set; }

    public virtual Federation Federation { get; set; }

    public string Sport { get; set; }

    public int? AgeGroup { get; set; }

    public int Level { get; set; }

    public string Host { get; set; }

    public string Year { get; set; }

    public int Medal { get; set; }

    public virtual Champion Champion { get; set; }
}
