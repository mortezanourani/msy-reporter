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

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<NationalTeamInvitee> NationalTeamInvitees { get; set; } = new List<NationalTeamInvitee>();

    public virtual ICollection<SportsCourseParticipant> SportsCourseParticipants { get; set; } = new List<SportsCourseParticipant>();

    public virtual ICollection<AthleticFacility> Facilities { get; set; } = new List<AthleticFacility>();

    public virtual ICollection<ConstructionProject> Projects { get; set; } = new List<ConstructionProject>();
}
