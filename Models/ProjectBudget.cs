using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class ProjectBudget
{
    public Guid ProjectId { get; set; }

    public string? Code { get; set; }

    public int Year { get; set; }

    public int SourceId { get; set; }

    public int Approved { get; set; }

    public virtual ConstructionProject Project { get; set; } = null!;

    public virtual FundingSource Source { get; set; } = null!;
}
