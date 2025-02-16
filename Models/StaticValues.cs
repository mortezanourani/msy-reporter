namespace Reporter.Models;

public static class StaticValues
{
    public static readonly Dictionary<int, string> Cities = new Dictionary<int, string>
    {
        { 0, "استان" },
        { 1, "آستارا" },
        { 2, "آستانه اشرفیه" },
        { 3, "املش" },
        { 4, "بندر انزلی" },
        { 5, "خمام" },
        { 6, "رشت" },
        { 7, "رضوانشهر" },
        { 8, "رودبار" },
        { 9, "رودسر" },
        { 10, "سیاهکل" },
        { 11, "شفت" },
        { 12, "صومعه سرا" },
        { 13, "طوالش" },
        { 14, "فومن" },
        { 15, "لاهیجان" },
        { 16, "لنگرود" },
        { 17, "ماسال" }
    };

    public static readonly Dictionary<int, string> SportFacilityTypes = new Dictionary<int, string>
    {
        { 1, "سرپوشیده" },
        { 2, "روباز" }
    };

    public static readonly Dictionary<int, string> SportFacilityGeoTypes = new Dictionary<int, string>
    {
        { 1, "شهری" },
        { 2, "روستایی" }
    };

    public static readonly Dictionary<int, string> SportFacilityOwnerships = new Dictionary<int, string>
    {
        { 1, "دولتی - وزارت ورزش و جوانان" },
        { 2, "دولتی - سایر ارگان ها" },
        { 3, "خصوصی - حقیقی" },
        { 4, "خصوصی - حقوقی" }
    };

    public static readonly Dictionary<int, string> SportFacilityGenders = new Dictionary<int, string>
    {
        { 1, "آقایان" },
        { 2, "بانوان" },
        { 3, "مشترک" }
    };

    public static readonly Dictionary<int, string> CourseTypes = new Dictionary<int, string>
    {
        { 1, "مربیگری" },
        { 2, "داوری" }
    };

    public static readonly Dictionary<int, string> CourseGrades = new Dictionary<int, string>
    {
        { 1, "درجه یک" },
        { 2, "درجه دو" },
        { 3, "درجه سه" }
    };

    public static readonly Dictionary<int, string> CourseGenders = new Dictionary<int, string>
    {
        { 1, "آقایان" },
        { 2, "بانوان" }
    };
}
