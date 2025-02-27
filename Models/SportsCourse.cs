using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class SportsCourse
{
    public Guid Id { get; set; }

    public bool IsCoaching { get; set; }

    public int GradeId { get; set; }

    public Guid FederationId { get; set; }

    public string Year { get; set; } = null!;

    public virtual Federation Federation { get; set; } = null!;

    public virtual SportsCourseGrade Grade { get; set; } = null!;

    public virtual ICollection<SportsCourseParticipant> Participants { get; set; } = new List<SportsCourseParticipant>();
}
