using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class NationalTeamCamp
{
    public Guid Id { get; set; }

    public int FederationId { get; set; }

    public string? Sport { get; set; }

    public int GenderId { get; set; }

    public int? AgeGroupId { get; set; }

    public int Year { get; set; }

    public int TypeId { get; set; }

    public string Location { get; set; } = null!;

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual ICollection<CampInvitee> CampInvitees { get; set; } = new List<CampInvitee>();

    public virtual Federation Federation { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;

    public virtual CampType Type { get; set; } = null!;
}
