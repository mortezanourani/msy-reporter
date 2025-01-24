namespace Reporter.Models;

public class City
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<SportFacility>? SportFacilities { get; set; }
}
