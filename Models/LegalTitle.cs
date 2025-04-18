﻿using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class LegalTitle
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? NormalizedTitle { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<M5license> M5licenses { get; set; } = new List<M5license>();
}
