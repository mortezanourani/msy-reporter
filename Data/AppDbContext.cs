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
            .HasDefaultValueSql("NEWID()");

            c.HasData(
                new City { Id = new Guid("18e0eb40-4b13-45a1-85c0-d53cb464664c"), Name = "آستارا" },
                new City { Id = new Guid("5d67f9d8-2dd3-4a8c-8ad6-b67c1423d057"), Name = "آستانه اشرفیه" },
                new City { Id = new Guid("342d716e-559f-4c48-8c7f-8482f9211ed8"), Name = "املش" },
                new City { Id = new Guid("95322eb2-7ac6-4e7a-bfd7-0708dd138ef0"), Name = "بندر انزلی" },
                new City { Id = new Guid("80415994-4405-48d6-bbfd-ed28ede04135"), Name = "خمام" },
                new City { Id = new Guid("44d2936c-3459-462e-92ea-57482ca780d7"), Name = "رشت" },
                new City { Id = new Guid("fe5f4ead-d6b2-4a9a-800f-72bff3ecdcec"), Name = "رضوانشهر" },
                new City { Id = new Guid("6bb9cfeb-b044-4337-8f0e-a87f92addd10"), Name = "رودبار" },
                new City { Id = new Guid("daf32ec4-9d10-4fba-8920-5a976a1b46d3"), Name = "رودسر" },
                new City { Id = new Guid("a1c0d297-9777-4bbd-996f-631bf22236e1"), Name = "سیاهکل" },
                new City { Id = new Guid("5b9813ba-1ddb-4019-bfcd-a13f41d15991"), Name = "شفت" },
                new City { Id = new Guid("9254a99b-9dfe-4064-85ae-9ce2b9d78880"), Name = "صومعه سرا" },
                new City { Id = new Guid("1826c821-3ac9-4366-80f8-a11dae790c61"), Name = "طوالش" },
                new City { Id = new Guid("01a37508-6a25-44a6-9e74-a3f979e59801"), Name = "فومن" },
                new City { Id = new Guid("7fcfba31-4a19-4586-95fc-6a791699d6b9"), Name = "لاهیجان" },
                new City { Id = new Guid("32046766-80ed-438a-b1e6-278e2e5fc80a"), Name = "لنگرود" },
                new City { Id = new Guid("f2d47051-1c40-49d1-9b8d-c237b1673378"), Name = "ماسال" }
            );
        });

        modelBuilder.Entity<Gender>(g =>
        {
            g.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            g.HasData(
                new Gender { Id = new Guid("a0980bed-ef44-44ca-b597-311b92918d4e"), Name = "آقایان" },
                new Gender { Id = new Guid("4cb421ce-c498-41cc-a8f1-ab67064515db"), Name = "بانوان" },
                new Gender { Id = new Guid("bdae5f66-529a-496a-a527-04a334e2ccda"), Name = "مشترک" }
            );
        });

        modelBuilder.Entity<GeoType>(gt =>
        {
            gt.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            gt.HasData(
                new GeoType { Id = new Guid("bf5eb862-9c2c-4182-8111-c9908fd64ccc"), Type = "شهری" },
                new GeoType { Id = new Guid("43848daf-90e8-45c4-91e3-410cf2fed6c0"), Type = "روستایی" }
            );
        });

        modelBuilder.Entity<SportFacilityType>(ft =>
        {
            ft.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            ft.HasData(
                new SportFacilityType { Id = new Guid("ba011bf4-ec24-406f-b495-3510c6e8858a"), Type = "سرپوشیده" },
                new SportFacilityType { Id = new Guid("2123bed5-0c83-45c8-af0b-cb2e6e3f4bf9"), Type = "روباز" }
            );
        });

        modelBuilder.Entity<SportFacilityOwnership>(fo =>
        {
            fo.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            fo.HasData(
                new SportFacilityOwnership { Id = new Guid("2169ee28-685c-440b-afc4-6ea4e606c8fa"), Name = "دولتی - وزارت ورزش و جوانان" },
                new SportFacilityOwnership { Id = new Guid("45a7a3b8-3fb6-4267-9c56-a055840966c1"), Name = "دولتی - سایر ارگان ها" },
                new SportFacilityOwnership { Id = new Guid("2feb419e-6e59-4f38-a82d-713d81677913"), Name = "خصوصی - حقیقی" },
                new SportFacilityOwnership { Id = new Guid("a886db9c-01a8-4f6c-9e17-7c4b3c9468ca"), Name = "خصوصی - حقوقی" }
            );
        });

        modelBuilder.Entity<SportFacilityStatus>(fs =>
        {
            fs.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            fs.HasData(
                new SportFacilityStatus { Id = new Guid("e30cb7ae-f7e2-4c3d-a612-f8ccd57f02c7"), Status = "فعال" },
                new SportFacilityStatus { Id = new Guid("65dc4d73-63f0-41ab-87ad-f04a1a88ec74"), Status = "غیر فعال" }
            );
        });

        modelBuilder.Entity<SportFacility>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Contract>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<LicenseType>(lt =>
        {
            lt.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            lt.HasData(
                new LicenseType { Id = new Guid("332bbac6-7c89-47d0-a050-782ea6c1a8f6"), Type = "حقیقی" },
                new LicenseType { Id = new Guid("625b65bf-d2ca-4180-baef-28d997f18aed"), Type = "حقوقی" }
            );
        });

        modelBuilder.Entity<LicenseOwnership>(lo =>
        {
            lo.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            lo.HasData(
                new LicenseOwnership { Id = new Guid("fbb67269-e44a-4f31-a690-e4b676cb0ada"), Name = "تملیکی" },
                new LicenseOwnership { Id = new Guid("3bf734c6-29f3-4006-b637-353c964b8108"), Name = "استیجاری" }
            );
        });

        modelBuilder.Entity<License>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");
    }
}
