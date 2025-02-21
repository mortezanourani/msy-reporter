﻿using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class M5BuildingOwnership
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string PersianName { get; set; }
}
