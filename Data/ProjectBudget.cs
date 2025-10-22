using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reporter.Data;

public partial class ProjectBudget
{
    [Key]
    public Guid Id { get; set; }

    public string? Code { get; set; }

    public int Year { get; set; }

    public int SourceId { get; set; }

    public int Approved { get; set; }

    public virtual ConstructionProject Project { get; set; } = null!;

    public virtual FundingSource Source { get; set; } = null!;
}
