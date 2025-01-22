using System.ComponentModel;

namespace Reporter.Models;

public class LicenseStatus
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Status { get; set; }
}
