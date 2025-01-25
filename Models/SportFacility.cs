using System.ComponentModel;

namespace Reporter.Models;

public class SportFacility
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public virtual SportFacilityType? Type { get; set; }

    public float? Area { get; set; }

    public virtual GeoType? GeoType { get; set; }

    public virtual City City { get; set; }

    public string? Location { get; set; }

    public virtual SportFacilityStatus Status { get; set; }

    public bool? hasDocument { get; set; }

    public string? Sports { get; set; }

    public virtual Gender? UsersGender { get; set; }

    public virtual SportFacilityOwnership Ownership { get; set; }

    public string? Owner { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public string? TelNumber { get; set; }

    // ماده 5
    public Guid? LicenseId { get; set; }

    // ماده 88
    public Guid? ContractId { get; set; }

    public DateTime Edited { get; set; } = DateTime.UtcNow;

    public virtual License? License { get; set; }

    public virtual Contract? Contract { get; set; }
}
