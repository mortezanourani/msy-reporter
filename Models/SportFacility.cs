using System.ComponentModel;

namespace Reporter.Models;

public class SportFacility
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; }

    // Building or Court
    public virtual BuildingType? Type { get; set; }

    public float? Area { get; set; }

    // City or Village
    public virtual GeoType? GeoType { get; set; }

    public virtual City City { get; set; }

    public string? Location { get; set; }

    // قابل بهره برداری / بهره برداری شده / غیر قابل بهره برداری
    public virtual string? Status { get; set; }

    public string? Sports { get; set; }

    public Gender? UsersGender { get; set; }

    // تملیکی / استیجاری / دولتی ورزش / دولتی سایر ارگان ها
    public BuildingOwnership BuildingOwnership { get; set; }

    public string? Zipcode { get; set; }

    public string? Address { get; set; }

    public string? TelNumber { get; set; }

    // M5
    public Guid? LicenseId { get; set; }

    // M88
    public Guid? ContractId { get; set; }

    public DateTime Edited { get; set; }

    public virtual License? License { get; set; }

    public virtual Contract? Contract { get; set; }
}
