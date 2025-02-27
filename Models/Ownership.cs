using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Ownership
{
    public int Id { get; set; }

    public bool IsGovernmentOwned { get; set; }

    public string Type { get; set; } = null!;

    public string? NormalizedType { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<AthleticFacility> AthleticFacilities { get; set; } = new List<AthleticFacility>();
}
