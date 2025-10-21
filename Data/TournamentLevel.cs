using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class TournamentLevel
{
    public int Id { get; set; }

    public bool IsInternational { get; set; }

    public string Title { get; set; } = null!;

    public string? NormalizedTitle { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
