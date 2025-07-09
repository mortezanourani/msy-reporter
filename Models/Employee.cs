using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class Employee
{
    public Guid Id { get; set; }

    public string SeenCode { get; set; } = null!;

    public int GenderId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PersonnelId { get; set; }

    public string? FatherName { get; set; }

    public string? BirthDate { get; set; }

    public int? TypeId { get; set; }

    public string? AccountId { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual EmploymentType? Type { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
