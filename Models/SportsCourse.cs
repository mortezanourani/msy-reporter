using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class SportsCourse
{
    [Key]
    public Guid Id { get; set; }
    public virtual SportsCourseType Type { get; set; }
    public virtual Federation Federation { get; set; }
    public virtual SportsCourseGrade Grade { get; set; }
    public virtual Gender Gender { get; set; }
    public string Year { get; set; }
    public virtual ICollection<CourseParticipant> Participants { get; set; } = new List<CourseParticipant>();
}
