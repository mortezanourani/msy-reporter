using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Tournament
{
    public Guid Id { get; set; }

    public int FederationId { get; set; }

    public string? Sport { get; set; }

    public int? AgeGroupId { get; set; }

    public int LevelId { get; set; }

    public string Host { get; set; } = null!;

    public int Year { get; set; }

    public int? Month { get; set; }

    public int? Day { get; set; }

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual ICollection<Champion> Champions { get; set; } = new List<Champion>();

    public virtual Federation Federation { get; set; } = null!;

    public virtual TournamentLevel Level { get; set; } = null!;
}
