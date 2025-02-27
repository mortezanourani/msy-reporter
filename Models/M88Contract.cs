using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class M88contract
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public string Serial { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public string Name { get; set; } = null!;

    public string SeenCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public Guid? M5licenseId { get; set; }

    public virtual AthleticFacility Facility { get; set; } = null!;

    public virtual M5license? M5license { get; set; }
}
