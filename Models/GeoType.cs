using System.ComponentModel;

namespace Reporter.Models;

public class GeoType
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Type { get; set; }
}
