using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class CourseParticipant
{
    [Key]
    public string Id { get; set; }
    public string Name { get; set; }
    public string SeenCode { get; set; }
    public string? Phone { get; set; }
}
