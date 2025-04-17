using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class CampType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? NormalizedType { get; set; }

    public string PersianType { get; set; } = null!;

    public virtual ICollection<NationalTeamCamp> NationalTeamCamps { get; set; } = new List<NationalTeamCamp>();
}
