using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class SportsCourseParticipant
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? SeenCode { get; set; }

    public string? Phone { get; set; }

    public int GenderId { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<SportsCourse> Courses { get; set; } = new List<SportsCourse>();
}
