using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class SportsCourseGrade
{
    public int Id { get; set; }

    public string Grade { get; set; } = null!;

    public string? NormalizedGrade { get; set; }

    public string PersianName { get; set; } = null!;

    public virtual ICollection<SportsCourse> SportsCourses { get; set; } = new List<SportsCourse>();
}
