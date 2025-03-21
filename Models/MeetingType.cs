using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class MeetingType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public string? NormalizedType { get; set; }

    public string PersianTitle { get; set; } = null!;

    public bool IsElective { get; set; }

    public virtual ICollection<FederationMeeting> FederationMeetings { get; set; } = new List<FederationMeeting>();
}
