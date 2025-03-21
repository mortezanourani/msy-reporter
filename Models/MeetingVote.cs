using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class MeetingVote
{
    public Guid MeetingId { get; set; }

    public string Name { get; set; } = null!;

    public int VotesCount { get; set; }

    public virtual FederationMeeting Meeting { get; set; } = null!;
}
