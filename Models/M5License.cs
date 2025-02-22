using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class M5License
{
    [Key]
    public Guid Id { get; set; }
    public virtual AthleticFacility AthleticFicility { get; set; }
    public virtual M5LicenseType? Type { get; set; }
    public virtual M5BuildingOwnership? Ownership { get; set; }
    public string? Serial { get; set; }
    public DateOnly? StartDate { get; set; }
    public DateOnly? ExpireDate { get; set; }
    public string? Company { get; set; }
    public string Name { get; set; }
    public string? SeenCode { get; set; }
    public string? Phone { get; set; }
    public virtual M5LicenseStatus? Status { get; set; }
}
