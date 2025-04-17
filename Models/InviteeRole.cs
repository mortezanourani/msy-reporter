using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class InviteeRole
{
    public int Id { get; set; }

    public string Role { get; set; } = null!;

    public string? NormalizedRole { get; set; }

    public string PersianRole { get; set; } = null!;

    public virtual ICollection<CampInvitee> CampInvitees { get; set; } = new List<CampInvitee>();
}
