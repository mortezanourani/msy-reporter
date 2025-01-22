using System.ComponentModel;

namespace Reporter.Models;

public class City
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Gym>? Gyms { get; set; }
}
