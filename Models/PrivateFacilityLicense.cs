using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class PrivateFacilityLicense
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public bool? IsBeneficial { get; set; }

    public bool? IsOwner { get; set; }

    public string? Serial { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public int UsersGenderId { get; set; }

    public string? Company { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public virtual PrivateFacility Facility { get; set; } = null!;

    public virtual UsersGender UsersGender { get; set; } = null!;
}
