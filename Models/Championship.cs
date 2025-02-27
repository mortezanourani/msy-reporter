using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Championship
{
    public Guid Id { get; set; }

    public Guid FederationId { get; set; }

    public string Sport { get; set; } = null!;

    public int? AgeGroupId { get; set; }

    public int EventLevelId { get; set; }

    public string Host { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int MedalId { get; set; }

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual EventLevel EventLevel { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;

    public virtual Medal Medal { get; set; } = null!;

    public virtual ICollection<Champion> Champions { get; set; } = new List<Champion>();
}
