using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Federation
{
    public Guid Id { get; set; }

    public int? CityId { get; set; }

    public string Name { get; set; } = null!;

    public string? NormalizedName { get; set; }

    public string PersianName { get; set; } = null!;

    public string? NationalId { get; set; }

    public string? Address { get; set; }

    public string? ZipCode { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<Championship> Championships { get; set; } = new List<Championship>();

    public virtual City? City { get; set; }

    public virtual ICollection<FederationMeeting> FederationMeetings { get; set; } = new List<FederationMeeting>();

    public virtual ICollection<FederationPresident> FederationPresidents { get; set; } = new List<FederationPresident>();

    public virtual ICollection<Insurance> Insurances { get; set; } = new List<Insurance>();

    public virtual ICollection<NationalTeamInvitee> NationalTeamInvitees { get; set; } = new List<NationalTeamInvitee>();

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();

    public virtual ICollection<SportsCourse> SportsCourses { get; set; } = new List<SportsCourse>();
}
