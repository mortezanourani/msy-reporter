using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
