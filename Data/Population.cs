namespace Reporter.Data;

public class Population
{
    public Guid Id { get; set; }

    public int CityId { get; set; }

    public int Year { get; set; }

    public int UrbanMen { get; set; }

    public int UrbanWomen { get; set; }

    public int RuralMen { get; set; }

    public int RuralWomen { get; set; }

    public virtual City City { get; set; } = null!;
}
