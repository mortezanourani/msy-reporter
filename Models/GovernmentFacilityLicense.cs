using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class GovernmentFacilityLicense
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public string? Serial { get; set; }

    public string? StartDate { get; set; }

    public string? ExpireDate { get; set; }

    public int UsersGenderId { get; set; }

    public string? MenSports { get; set; }

    public string? WomenSports { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public virtual GovernmentFacility Facility { get; set; } = null!;

    public virtual UsersGender UsersGender { get; set; } = null!;
}
