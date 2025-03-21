using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class AthleticFacility
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int OwnershipId { get; set; }

    public int? TypeId { get; set; }

    public bool? IsRural { get; set; }

    public int CityId { get; set; }

    public string? District { get; set; }

    public int? Area { get; set; }

    public bool IsActive { get; set; }

    public string? Sports { get; set; }

    public string? ZipCode { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<M5license> M5licenses { get; set; } = new List<M5license>();

    public virtual ICollection<M88contract> M88contracts { get; set; } = new List<M88contract>();

    public virtual Ownership Ownership { get; set; } = null!;

    public virtual FacilityType? Type { get; set; }

    public virtual ICollection<Gender> Genders { get; set; } = new List<Gender>();
}
