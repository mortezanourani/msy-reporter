using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class M88Contract
{
    [Key]
    public Guid Id { get; set; }
    public virtual AthleticFacility AthleticFacility { get; set; }
    public string Serial { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly ExpireDate { get; set; }
    public string Name { get; set; }
    public string SeenCode { get; set; }
    public string Phone { get; set; }
    public virtual M5License? M5License { get; set; }
}
