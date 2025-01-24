using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<LicenseOwnership> BuildingOwnerships { get; set; }

    public DbSet<SportFacilityType> BuildingTypes { get; set; }

    public DbSet<City> Cities { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    public DbSet<Gender> Genders { get; set; }

    public DbSet<GeoType> GeoTypes { get; set; }

    public DbSet<License> Licenses { get; set; }

    public DbSet<LicenseType> LicenseOwnerships { get; set; }

    public DbSet<LicenseStatus> LicenseStatus { get; set; }

    public DbSet<SportFacility> SportsFacilities { get; set; }
}
