using System;
using System.Collections.Generic;

namespace Reporter.Data;

public partial class EmploymentType
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? NormalizedTitle { get; set; }

    public string PersianTitle { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
