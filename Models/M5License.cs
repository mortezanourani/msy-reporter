using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class M5license
{
    public Guid Id { get; set; }

    public Guid FacilityId { get; set; }

    public int? LegalTitleId { get; set; }

    public bool? IsOwner { get; set; }

    public string? Serial { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public string? Company { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public virtual AthleticFacility Facility { get; set; } = null!;

    public virtual LegalTitle? LegalTitle { get; set; }

    public virtual ICollection<M88contract> M88contracts { get; set; } = new List<M88contract>();
}
