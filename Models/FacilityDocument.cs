using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FacilityDocument
{
    public Guid Id { get; set; }

    public Guid? FacilityId { get; set; }

    public bool IsNew { get; set; }

    public string? Serial { get; set; }

    public int? PrimaryCode { get; set; }

    public int? SecondaryCode { get; set; }

    public double? Area { get; set; }

    public string? Date { get; set; }

    public virtual Facility? Facility { get; set; }
}
