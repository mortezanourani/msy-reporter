namespace Reporter.Models;

public class SportFacilityLicense
{
    public Guid Id { get; set; }

    public int Type { get; set; }

    public int Ownership { get; set; }

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
