using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();
}
