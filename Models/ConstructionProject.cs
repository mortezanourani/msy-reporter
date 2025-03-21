using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class ConstructionProject
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public int CityId { get; set; }

    public bool? IsRural { get; set; }

    public bool IsRenovation { get; set; }

    public int TypeId { get; set; }

    public int StartYear { get; set; }

    public int? FinishYear { get; set; }

    public int Area { get; set; }

    public int SportArea { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual ICollection<ProjectBudget> ProjectBudgets { get; set; } = new List<ProjectBudget>();

    public virtual ICollection<ProjectCompletionProgress> ProjectCompletionProgresses { get; set; } = new List<ProjectCompletionProgress>();

    public virtual FacilityType Type { get; set; } = null!;

    public virtual ICollection<Gender> Genders { get; set; } = new List<Gender>();
}
