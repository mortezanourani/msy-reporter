using System.ComponentModel;

namespace Reporter.Models;

public class SportFacility
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    // سرپوشیده / روباز
    public virtual SportFacilityType? Type { get; set; }

    public float? Area { get; set; }

    // شهری / روستایی
    public virtual GeoType? GeoType { get; set; }

    public virtual City City { get; set; }

    public string? Location { get; set; }

    // قابل بهره برداری / بهره برداری شده / غیر قابل بهره برداری
    public virtual string? Status { get; set; }

    public string? Sports { get; set; }

    public virtual Gender? UsersGender { get; set; }

    // دولتی وزارت ورزش / خصوصی / دولتی سایر ارگان ها
    public virtual SportFacilityOwnership Ownership { get; set; }

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
