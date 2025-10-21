using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class ConstructionProject
{
    public Guid Id { get; set; }

    public int CityId { get; set; }

    public Guid? FacilityId { get; set; }

    public string Title { get; set; } = null!;

    public int? TypeId { get; set; }

    public int Year { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Facility? Facility { get; set; }

    public virtual ICollection<ProjectBudget> ProjectBudgets { get; set; } = new List<ProjectBudget>();

    public virtual ICollection<ProjectProgress> ProjectProgresses { get; set; } = new List<ProjectProgress>();

    public virtual ProjectType? Type { get; set; }
}
