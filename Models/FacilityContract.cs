using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FacilityContract
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public string Serial { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public Guid? LegalContractorId { get; set; }

    public string Name { get; set; } = null!;

    public string SeenCode { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? LicenseSerial { get; set; }

    public DateOnly? LicenseDate { get; set; }

    public virtual Facility Facility { get; set; } = null!;

    public virtual LocalFederation? LegalContractor { get; set; }
}
