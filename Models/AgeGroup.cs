using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class AgeGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<NationalTeamCamp> NationalTeamCamps { get; set; } = new List<NationalTeamCamp>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
