using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class AgeGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();

    public virtual ICollection<NationalTeamInvitee> NationalTeamInvitees { get; set; } = new List<NationalTeamInvitee>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
