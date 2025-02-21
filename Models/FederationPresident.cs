using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class FederationPresident
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string SeedCode { get; set; }
    public string BirthDate { get; set; }
    public string Phone { get; set; }
    public string? AppointmentOrder { get; set; }
    public string? AppointmentDate { get; set; }
}
