namespace Reporter.Models;

public static class StaticValues
{
    public static readonly Dictionary<int, string> CourseTypes = new Dictionary<int, string>
    {
        { 1, "مربیگری" },
        { 2, "داوری" }
    };

    public static readonly Dictionary<int, string> CourseGrade = new Dictionary<int, string>
    {
        { 1, "درجه یک" },
        { 2, "درجه دو" },
        { 3, "درجه سه" }
    };

    public static readonly Dictionary<int, string> CourseGender = new Dictionary<int, string>
    {
        { 1, "آقایان" },
        { 2, "بانوان" }
    };
}
