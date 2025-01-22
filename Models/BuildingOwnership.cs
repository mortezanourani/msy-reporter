﻿using System.ComponentModel;

namespace Reporter.Models;

public class BuildingOwnership
{
    [DefaultValue("NewId()")]
    public Guid Id { get; set; }

    public string Name { get; set; }
}
