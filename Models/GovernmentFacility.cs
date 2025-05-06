using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class GovernmentFacility
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Owner { get; set; }

    public int? TypeId { get; set; }

    public int CityId { get; set; }

    public string? District { get; set; }

    public bool? IsRural { get; set; }

    public int? Area { get; set; }

    public int? SportHallArea { get; set; }

    public int? SportLandArea { get; set; }

    public bool IsActive { get; set; }

    public string? ZipCode { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<GovernmentFacilityLicense> GovernmentFacilityLicenses { get; set; } = new List<GovernmentFacilityLicense>();

    public virtual FacilityType? Type { get; set; }
}
