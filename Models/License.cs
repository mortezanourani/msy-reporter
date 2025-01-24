namespace Reporter.Models;

public class License
{
    public Guid Id { get; set; }

    // دولتی / خصوصی - حقیقی / خصوصی - حقوقی
    public virtual LicenseOwnership Ownership { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly ExtensionDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    // فعال / منقضی / غیرفعال
    public virtual LicenseStatus? Status { get; set; }

    public string? CompanyName { get; set; }

    public string OwnerName { get; set; }

    public string? OwnerSeenCode { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual SportFacility SportFacility { get; set; }
}
