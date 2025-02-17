namespace Reporter.Models;

public class SportFacilityContract
{
    public Guid Id { get; set; }

    public string OwnerName { get; set; }

    public string OwnerSeenCode { get; set; }

    public string PhoneNumber { get; set; }

    public string Number { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly ExpireDate { get; set; }

    public bool IsExpired { get; set; }

    public virtual SportFacility SportFacility { get; set; }
}
