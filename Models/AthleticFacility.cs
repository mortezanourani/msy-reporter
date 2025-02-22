using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class AthleticFacility
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual FacilityOwnership Ownership { get; set; }
    public virtual FacilityType? Type { get; set; }
    public virtual FacilityGeoType? GeoType { get; set; }
    public virtual City City { get; set; }
    public string? District { get; set; }
    public float? Area { get; set; }
    public virtual FacilityStatus? Status { get; set; }
    public virtual FacilityUsersGender? UsersGender { get; set; }
    public string? Sports { get; set; }
    public string? Zipcode { get; set; }
    public string? Address { get; set; }
    public string? TelNumber { get; set; }
}
