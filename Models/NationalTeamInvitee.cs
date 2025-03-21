using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class NationalTeamInvitee
{
    public Guid Id { get; set; }

    public int RoleId { get; set; }

    public string Name { get; set; } = null!;

    public int GenderId { get; set; }

    public Guid FederationId { get; set; }

    public int? AgeGroupId { get; set; }

    public int Year { get; set; }

    public bool IsAccepted { get; set; }

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual Federation Federation { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;

    public virtual InviteeRole Role { get; set; } = null!;
}
