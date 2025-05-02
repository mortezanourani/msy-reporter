using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class UsersGender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Facility> Facilities { get; set; } = new List<Facility>();

    public virtual ICollection<GovernmentFacility> GovernmentFacilities { get; set; } = new List<GovernmentFacility>();

    public virtual ICollection<PrivateFacilityLicense> PrivateFacilityLicenses { get; set; } = new List<PrivateFacilityLicense>();
}
