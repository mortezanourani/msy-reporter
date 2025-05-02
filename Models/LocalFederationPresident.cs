using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class LocalFederationPresident
{
    public Guid Id { get; set; }

    public Guid FederationId { get; set; }

    public string Name { get; set; } = null!;

    public string SeenCode { get; set; } = null!;

    public string BirthDate { get; set; } = null!;

    public string? Phone { get; set; }

    public string? EducationalQualification { get; set; }

    public string? EducationalMajor { get; set; }

    public string? AppointmentOrder { get; set; }

    public string? AppointmentDate { get; set; }

    public string? TermEnd { get; set; }

    public bool IsPresident { get; set; }

    public virtual LocalFederation Federation { get; set; } = null!;
}
