using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class SportCourse
{
    [Key]
    public Guid Id { get; set; }

    public int Type { get; set; }

    public virtual Federation Federation { get; set; }

    public int Grade { get; set; }

    public int Gender { get; set; }

    public DateOnly CourseDate { get; set; }

    public DateOnly CertificateDate { get; set; }

    public virtual ICollection<SportCourseParticipant>? Participants { get; set; }
}
