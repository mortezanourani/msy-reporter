using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class LocalFederation
{
    public Guid Id { get; set; }

    public int FederationId { get; set; }

    public int CityId { get; set; }

    public string? District { get; set; }

    public string? NationalId { get; set; }

    public string? Address { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<FacilityContract> FacilityContracts { get; set; } = new List<FacilityContract>();

    public virtual Federation Federation { get; set; } = null!;

    public virtual ICollection<LocalFederationPresident> LocalFederationPresidents { get; set; } = new List<LocalFederationPresident>();
}
