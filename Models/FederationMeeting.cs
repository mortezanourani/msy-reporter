using System;
using System.Collections.Generic;

namespace Reporter.Models;

public partial class FederationMeeting
{
    public Guid Id { get; set; }

    public int FederationId { get; set; }

    public int TypeId { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Day { get; set; }

    public int AttendeesCount { get; set; }

    public virtual Federation Federation { get; set; } = null!;

    public virtual ICollection<MeetingVote> MeetingVotes { get; set; } = new List<MeetingVote>();

    public virtual MeetingType Type { get; set; } = null!;
}
