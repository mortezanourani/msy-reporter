using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<City> Cities { get; set; }

    public DbSet<Gender> Genders { get; set; }

    public DbSet<GeoType> GeoTypes { get; set; }

    public DbSet<SportFacilityType> SportFacilityTypes { get; set; }

    public DbSet<SportFacilityOwnership> SportFacilityOwnerships { get; set; }

    public DbSet<SportFacilityStatus> SportFacilityStatuses { get; set; }

    public DbSet<SportFacility> SportsFacilities { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    public DbSet<LicenseType> LicenseTypes { get; set; }

    public DbSet<LicenseOwnership> LicenseOwnerships { get; set; }

    public DbSet<License> Licenses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<City>(c =>
        {
            c.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            c.HasData(
                new City { Id = 1, Name = "آستارا" },
                new City { Id = 2, Name = "آستانه اشرفیه" },
                new City { Id = 3, Name = "املش" },
                new City { Id = 4, Name = "بندر انزلی" },
                new City { Id = 5, Name = "خمام" },
                new City { Id = 6, Name = "رشت" },
                new City { Id = 7, Name = "رضوانشهر" },
                new City { Id = 8, Name = "رودبار" },
                new City { Id = 9, Name = "رودسر" },
                new City { Id = 10, Name = "سیاهکل" },
                new City { Id = 11, Name = "شفت" },
                new City { Id = 12, Name = "صومعه سرا" },
                new City { Id = 13, Name = "طوالش" },
                new City { Id = 14, Name = "فومن" },
                new City { Id = 15, Name = "لاهیجان" },
                new City { Id = 16, Name = "لنگرود" },
                new City { Id = 17, Name = "ماسال" },
                new City { Id = 18, Name = "استان" }
            );
        });

        modelBuilder.Entity<Gender>(g =>
        {
            g.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            g.HasData(
                new Gender { Id = 1, Name = "آقایان" },
                new Gender { Id = 2, Name = "بانوان" },
                new Gender { Id = 3, Name = "مشترک" }
            );
        });

        modelBuilder.Entity<GeoType>(gt =>
        {
            gt.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            gt.HasData(
                new GeoType { Id = 1, Type = "شهری" },
                new GeoType { Id = 2, Type = "روستایی" }
            );
        });

        modelBuilder.Entity<SportFacilityType>(ft =>
        {
            ft.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            ft.HasData(
                new SportFacilityType { Id = 1, Type = "سرپوشیده" },
                new SportFacilityType { Id = 2, Type = "روباز" }
            );
        });

        modelBuilder.Entity<SportFacilityOwnership>(fo =>
        {
            fo.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            fo.HasData(
                new SportFacilityOwnership { Id = 1, Name = "دولتی - وزارت ورزش و جوانان" },
                new SportFacilityOwnership { Id = 2, Name = "دولتی - سایر ارگان ها" },
                new SportFacilityOwnership { Id = 3, Name = "خصوصی - حقیقی" },
                new SportFacilityOwnership { Id = 4, Name = "خصوصی - حقوقی" }
            );
        });

        modelBuilder.Entity<SportFacilityStatus>(fs =>
        {
            fs.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            fs.HasData(
                new SportFacilityStatus { Id = 1, Status = "فعال" },
                new SportFacilityStatus { Id = 2, Status = "غیر فعال" }
            );
        });

        modelBuilder.Entity<SportFacility>(f =>
        {
            f.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            f.Property(e => e.Edited)
            .HasDefaultValueSql("GETDATE()");
        });

        modelBuilder.Entity<Contract>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<LicenseType>(lt =>
        {
            lt.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            lt.HasData(
                new LicenseType { Id = 1, Type = "حقیقی" },
                new LicenseType { Id = 2, Type = "حقوقی" }
            );
        });

        modelBuilder.Entity<LicenseOwnership>(lo =>
        {
            lo.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            lo.HasData(
                new LicenseOwnership { Id = 1, Name = "تملیکی" },
                new LicenseOwnership { Id = 2, Name = "استیجاری" }
            );
        });

        modelBuilder.Entity<License>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");
    }
}
