using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class FacilityType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? NormalizedType { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual ICollection<GovernmentFacility> GovernmentFacilities { get; set; } = new List<GovernmentFacility>();

    public virtual ICollection<PrivateFacility> PrivateFacilities { get; set; } = new List<PrivateFacility>();
}
