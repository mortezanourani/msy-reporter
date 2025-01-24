namespace Reporter.Models;

public class License
{
    public Guid Id { get; set; }

    // حقوقی / حقیقی
    public virtual LicenseType Type { get; set; }

    // تملیکی / استیجاری / دولتی
    public virtual LicenseOwnership Ownership { get; set; }

    // فعال / منقضی / غیرفعال
    public virtual LicenseStatus? Status { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly ExtensionDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public string? CompanyName { get; set; }

    public string OwnerName { get; set; }

    public string? OwnerSeenCode { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual SportFacility SportFacility { get; set; }
}
