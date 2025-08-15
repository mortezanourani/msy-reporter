using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Department
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;
}
