using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class FundingSource
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? NormalizedTitle { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<ProjectBudget> ProjectBudgets { get; set; } = new List<ProjectBudget>();
}
