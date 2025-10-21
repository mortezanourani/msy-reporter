using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class Federation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public bool IsPara { get; set; }

    public bool IsChampionship { get; set; }

    public bool IsGeneral { get; set; }

    public bool IsRural { get; set; }

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<LocalFederation> LocalFederations { get; set; } = new List<LocalFederation>();

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
