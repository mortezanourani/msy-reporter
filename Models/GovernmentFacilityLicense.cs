using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class GovernmentFacilityLicense
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public string? Serial { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public virtual GovernmentFacility Facility { get; set; } = null!;
}
