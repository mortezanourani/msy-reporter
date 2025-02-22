using System.ComponentModel.DataAnnotations;

namespace Reporter.Models;

public class Championship
{
    [Key]
    public Guid Id { get; set; }
    public virtual Federation Federation { get; set; }
    public string Sport { get; set; }
    public TournamentAgeGroup? AgeGroup { get; set; }
    public TournamentLevel Level { get; set; }
    public string Host { get; set; }
    public string Year { get; set; }
    public ChampionshipMedal Medal { get; set; }
}
