using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Federation
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<CityFederation> CityFederations { get; set; } = new List<CityFederation>();

    public virtual ICollection<FederationMeeting> FederationMeetings { get; set; } = new List<FederationMeeting>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<NationalTeamCamp> NationalTeamCamps { get; set; } = new List<NationalTeamCamp>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();

    public virtual ICollection<SportsCourse> SportsCourses { get; set; } = new List<SportsCourse>();

    public virtual ICollection<Tournament> Tournaments { get; set; } = new List<Tournament>();
}
