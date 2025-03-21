using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class ProjectCompletionProgress
{
    public Guid ProjectId { get; set; }

    public int Year { get; set; }

    public int Percentage { get; set; }

    public int? CompletionYear { get; set; }

    public virtual ConstructionProject Project { get; set; } = null!;
}
