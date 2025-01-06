using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Gender> Genders { get; set; }

    public DbSet<BuildingOwnership> BuildingOwnerships { get; set; }
}
