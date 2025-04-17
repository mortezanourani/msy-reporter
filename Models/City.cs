using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();

    public virtual ICollection<AthleticFacility> AthleticFacilities { get; set; } = new List<AthleticFacility>();

    public virtual ICollection<CityFederation> CityFederations { get; set; } = new List<CityFederation>();

    public virtual ICollection<ConstructionProject> ConstructionProjects { get; set; } = new List<ConstructionProject>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();
}
