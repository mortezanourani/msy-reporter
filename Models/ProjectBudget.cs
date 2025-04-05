using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class ProjectBudget
{
    public Guid ProjectId { get; set; }

    public int Year { get; set; }

    public int ApprovedBudgets { get; set; }

    public int? ContractorUnpaid { get; set; }

    public int? CompletionBudget { get; set; }

    public string? FundingSource { get; set; }

    public virtual ConstructionProject Project { get; set; } = null!;
}
