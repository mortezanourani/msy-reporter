using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FederationPresident
{
    public Guid Id { get; set; }

    public int FederationId { get; set; }

    public int CityId { get; set; }

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

    public virtual CityFederation CityFederation { get; set; } = null!;
}
