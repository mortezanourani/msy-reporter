using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class EventLevel
{
    public int Id { get; set; }

    public bool IsInternational { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();
}
