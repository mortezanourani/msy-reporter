using System.ComponentModel;

namespace Reporter.Models;

public class Gym
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    public virtual LicenseOwnership Ownership { get; set; }

    public DateOnly LicenseDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public LicenseStatus? Status { get; set; }

    public string? CompanyName { get; set; }

    public string OwnerName { get; set; }

    public string? OwnerSeenCode { get; set; }

    public string? PhoneNumber { get; set; }

    public LocationType? LocationType { get; set; }

    public virtual City City { get; set; }

    public string? Location { get; set; }

    public BuildingOwnership BuildingOwnership { get; set; }

    public BuildingType? BuildingType { get; set; }

    public float? Area { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public string? TelNumber { get; set; }

    public string? Sports { get; set; }

    public Gender? UsersGender { get; set; }

    [DefaultValue("DateTime.Now()")]
    public DateTime Edited { get; set; }
}
