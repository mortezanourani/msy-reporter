using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Facility
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int? TypeId { get; set; }

    public int CityId { get; set; }

    public bool? IsRural { get; set; }

    public string? District { get; set; }

    public int? Area { get; set; }

    public int? SportHallArea { get; set; }

    public int? SportLandArea { get; set; }

    public bool IsActive { get; set; }

    public int UsersGenderId { get; set; }

    public string? Sports { get; set; }

    public string? ZipCode { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public bool IsSubFacility { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<ConstructionProject> ConstructionProjects { get; set; } = new List<ConstructionProject>();

    public virtual ICollection<FacilityContract> FacilityContracts { get; set; } = new List<FacilityContract>();

    public virtual ICollection<FacilityDocument> FacilityDocuments { get; set; } = new List<FacilityDocument>();

    public virtual FacilityType? Type { get; set; }

    public virtual UsersGender UsersGender { get; set; } = null!;
}
