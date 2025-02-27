using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Medal
{
    public int Id { get; set; }

    public bool IsIndividualMedal { get; set; }

    public string Color { get; set; } = null!;

    public string? NormalizedColor { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();
}
