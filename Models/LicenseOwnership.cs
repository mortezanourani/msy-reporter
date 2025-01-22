using System.ComponentModel;

namespace Reporter.Models;

public class LicenseOwnership
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Name { get; set; }
}
