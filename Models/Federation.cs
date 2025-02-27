using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Federation
{
    public Guid Id { get; set; }

    public int? CityId { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public string? NationalId { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();

    public virtual City? City { get; set; }

    public virtual ICollection<FederationPresident> FederationPresidents { get; set; } = new List<FederationPresident>();

    public virtual ICollection<SportsCourse> SportsCourses { get; set; } = new List<SportsCourse>();
}
