using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FederationPresident
{
    public Guid Id { get; set; }

    public Guid? FederationId { get; set; }

    public string Name { get; set; } = null!;

    public string SeedCode { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public string? Phone { get; set; }

    public string? AppointmentOrder { get; set; }

    public string? AppointmentDate { get; set; }

    public virtual Federation? Federation { get; set; }
}
