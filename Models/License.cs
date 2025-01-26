namespace Reporter.Models;

public class License
{
    public Guid Id { get; set; }

    public virtual LicenseType Type { get; set; }

    public virtual LicenseOwnership Ownership { get; set; }

    public string? Serial { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public string? CompanyName { get; set; }

    public string Owner { get; set; }

    public string? OwnerSeenCode { get; set; }

    public string? PhoneNumber { get; set; }

    public bool IsExpired { get; set; }

    public virtual SportFacility SportFacility { get; set; }
}
