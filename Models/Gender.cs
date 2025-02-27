using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<Champion> Champions { get; set; } = new List<Champion>();

    public virtual ICollection<SportsCourseParticipant> SportsCourseParticipants { get; set; } = new List<SportsCourseParticipant>();

    public virtual ICollection<AthleticFacility> Facilities { get; set; } = new List<AthleticFacility>();
}
