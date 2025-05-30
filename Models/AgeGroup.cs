﻿using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class AgeGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Champion> Champions { get; set; } = new List<Champion>();
}
