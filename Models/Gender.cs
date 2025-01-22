using System.ComponentModel;

namespace Reporter.Models;

public class Gender
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Name { get; set; }
}
