﻿using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Champion
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public int GenderId { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();
}
