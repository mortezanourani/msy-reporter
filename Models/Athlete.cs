using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Athlete
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public int GenderId { get; set; }

    public int CityId { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<CampInvitee> CampInvitees { get; set; } = new List<CampInvitee>();

    public virtual ICollection<Champion> Champions { get; set; } = new List<Champion>();

    public virtual City City { get; set; } = null!;

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<Record> Records { get; set; } = new List<Record>();
}
