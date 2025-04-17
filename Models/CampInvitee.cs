using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class CampInvitee
{
    public Guid CampId { get; set; }

    public Guid AthleteId { get; set; }

    public int RoleId { get; set; }

    public virtual Athlete Athlete { get; set; } = null!;

    public virtual NationalTeamCamp Camp { get; set; } = null!;

    public virtual InviteeRole Role { get; set; } = null!;
}
