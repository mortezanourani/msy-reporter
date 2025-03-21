using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FacilityType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<AthleticFacility> AthleticFacilities { get; set; } = new List<AthleticFacility>();

    public virtual ICollection<ConstructionProject> ConstructionProjects { get; set; } = new List<ConstructionProject>();
}
