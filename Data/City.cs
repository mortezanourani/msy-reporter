using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Athlete> Athletes { get; set; } = new List<Athlete>();

    public virtual ICollection<ConstructionProject> ConstructionProjects { get; set; } = new List<ConstructionProject>();

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual ICollection<GovernmentFacility> GovernmentFacilities { get; set; } = new List<GovernmentFacility>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<LocalFederation> LocalFederations { get; set; } = new List<LocalFederation>();

    public virtual ICollection<PrivateFacility> PrivateFacilities { get; set; } = new List<PrivateFacility>();
}
