using System.ComponentModel;

namespace Reporter.Models;

public class SportFacility
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public int? Type { get; set; }

    public float? Area { get; set; }

    public int? GeoType { get; set; }

    public int City { get; set; }

    public string? Location { get; set; }

    public bool? Status { get; set; }

    public bool? hasDocument { get; set; }

    public string? Sports { get; set; }

    public int? UsersGender { get; set; }

    public int? Ownership { get; set; }

    public string? Owner { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public string? TelNumber { get; set; }

    public Guid? LicenseId { get; set; }

    public Guid? ContractId { get; set; }

    public DateTime Edited { get; set; }

    public virtual SportFacilityLicense? License { get; set; }

    public virtual SportFacilityContract? Contract { get; set; }
}
