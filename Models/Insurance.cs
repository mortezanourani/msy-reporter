using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Insurance
{
    public Guid Id { get; set; }

    public int CityId { get; set; }

    public Guid FederationId { get; set; }

    public int GenderId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Count { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;
}
