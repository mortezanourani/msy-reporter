﻿using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class FacilityUsersGender
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PersianName { get; set; }
}
