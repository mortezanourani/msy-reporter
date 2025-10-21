using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class Insurance
{
    public Guid Id { get; set; }

    public int CityId { get; set; }

    public int FederationId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int MenCount { get; set; }

    public int WomenCount { get; set; }

    public virtual City City { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;
}
