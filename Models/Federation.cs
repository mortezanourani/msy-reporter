using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class Federation
{
    [Key]
    public Guid Id { get; set; }
    public virtual City City { get; set; }
    public string Name { get; set; }
    public string PersianName { get; set; }
    public string? NationalId { get; set; }
    public string? Address { get; set; }
    public virtual ICollection<FederationPresident> FederationPresidents { get; set; } = new List<FederationPresident>();
}
