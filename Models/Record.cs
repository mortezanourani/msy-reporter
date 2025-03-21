using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Record
{
    public Guid Id { get; set; }

    public Guid FederationId { get; set; }

    public string Sport { get; set; } = null!;

    public int? AgeGroupId { get; set; }

    public string OldRecord { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int CityId { get; set; }

    public string? Location { get; set; }

    public string Current { get; set; } = null!;

    public virtual AgeGroup? AgeGroup { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;
}
