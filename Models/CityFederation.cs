using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class CityFederation
{
    public int FederationId { get; set; }

    public int CityId { get; set; }

    public string? NationalId { get; set; }

    public string? Address { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;

    public virtual ICollection<FederationPresident> FederationPresidents { get; set; } = new List<FederationPresident>();
}
