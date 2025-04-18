﻿using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Record
{
    public Guid Id { get; set; }

    public Guid AthleteId { get; set; }

    public int FederationId { get; set; }

    public string Sport { get; set; } = null!;

    public int? AgeGroupId { get; set; }

    public string Date { get; set; } = null!;

    public string? Host { get; set; }

    public string Old { get; set; } = null!;

    public string New { get; set; } = null!;

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual Athlete Athlete { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;
}
