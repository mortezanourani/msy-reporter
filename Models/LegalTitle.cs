using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class LegalTitle
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<M5license> M5licenses { get; set; } = new List<M5license>();
}
