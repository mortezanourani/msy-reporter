using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class ProjectProgress
{
    public Guid ProjectId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Percentage { get; set; }

    public int? ContractorUnpaid { get; set; }

    public int? CompletionBudget { get; set; }

    public int? CompletionYear { get; set; }

    public virtual ConstructionProject Project { get; set; } = null!;
}
