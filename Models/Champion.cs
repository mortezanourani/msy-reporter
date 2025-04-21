using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Champion
{
    public Guid Id { get; set; }

    public Guid AthleteId { get; set; }

    public Guid TournamentId { get; set; }

    public string? Field { get; set; }

    public int? AgeGroupId { get; set; }

    public int? MedalId { get; set; }

    public int? MedalsCount { get; set; }

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual Athlete Athlete { get; set; } = null!;

    public virtual Medal? Medal { get; set; }

    public virtual Tournament Tournament { get; set; } = null!;
}
