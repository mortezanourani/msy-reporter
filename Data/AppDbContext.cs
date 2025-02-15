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
    
    public DbSet<Federation> Federations { get; set; }
    
    public DbSet<SportCourse> Courses { get; set; }

    public DbSet<CourseParticipant> CourseParticipants { get; set; }
    
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

        modelBuilder.Entity<Federation>(f =>
        {
            f.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            f.HasData(
                new Federation { Id = 1, Name = "اتومبیلرانی و موتورسواری" },
                new Federation { Id = 2, Name = "اسکواش" },
                new Federation { Id = 3, Name = "اسکی" },
                new Federation { Id = 4, Name = "اسکیت" },
                new Federation { Id = 5, Name = "انجمن های ورزش های رزمی" },
                new Federation { Id = 6, Name = "انجمن‌های ورزشی" },
                new Federation { Id = 7, Name = "آمادگی جسمانی" },
                new Federation { Id = 8, Name = "بدمینتون" },
                new Federation { Id = 9, Name = "بدنسازی و پرورش اندام" },
                new Federation { Id = 10, Name = "بسکتبال" },
                new Federation { Id = 11, Name = "بوکس" },
                new Federation { Id = 12, Name = "بولینگ، بیلیارد و بولس" },
                new Federation { Id = 13, Name = "پزشکی ورزشی" },
                new Federation { Id = 14, Name = "تکواندو" },
                new Federation { Id = 15, Name = "تنیس" },
                new Federation { Id = 16, Name = "تنیس روی میز" },
                new Federation { Id = 17, Name = "تیراندازی" },
                new Federation { Id = 18, Name = "تیراندازی با کمان" },
                new Federation { Id = 19, Name = "جودو" },
                new Federation { Id = 20, Name = "چوگان" },
                new Federation { Id = 21, Name = "دو و میدانی" },
                new Federation { Id = 22, Name = "دوچرخه سواری" },
                new Federation { Id = 23, Name = "ژیمناستیک" },
                new Federation { Id = 24, Name = "سه گانه" },
                new Federation { Id = 25, Name = "سوارکاری" },
                new Federation { Id = 26, Name = "شطرنج" },
                new Federation { Id = 27, Name = "شمشیربازی" },
                new Federation { Id = 28, Name = "شنا، شیرجه و واترپلو" },
                new Federation { Id = 29, Name = "فوتبال" },
                new Federation { Id = 30, Name = "قایقرانی" },
                new Federation { Id = 31, Name = "کاراته" },
                new Federation { Id = 32, Name = "کبدی" },
                new Federation { Id = 33, Name = "کشتی" },
                new Federation { Id = 34, Name = "کونگ فو و هنرهای رزمی" },
                new Federation { Id = 35, Name = "کوهنوردی و صعود ورزشی" },
                new Federation { Id = 36, Name = "گلف" },
                new Federation { Id = 37, Name = "نجات غریق و غواصی" },
                new Federation { Id = 38, Name = "هاکی" },
                new Federation { Id = 39, Name = "هندبال" },
                new Federation { Id = 40, Name = "والیبال" },
                new Federation { Id = 41, Name = "ورزش باستانی و پهلوانی" },
                new Federation { Id = 42, Name = "ورزش روستائی و بازی های بومی" },
                new Federation { Id = 43, Name = "ورزش های بیماریهای خاص" },
                new Federation { Id = 44, Name = "ورزش های جانبازان و توانیابان" },
                new Federation { Id = 45, Name = "ورزش های نابینایان و کم بینایان" },
                new Federation { Id = 46, Name = "ورزش های ناشنوایان و کم شنوایان" },
                new Federation { Id = 47, Name = "ورزش های همگانی" },
                new Federation { Id = 48, Name = "ورزش های دانش‌آموزی" },
                new Federation { Id = 49, Name = "ورزش های دانشگاهی" },
                new Federation { Id = 50, Name = "ورزش های کارگری" },
                new Federation { Id = 51, Name = "وزنه برداری" },
                new Federation { Id = 52, Name = "ووشو" }
            );
        });

        modelBuilder.Entity<SportCourse>()
            .Property(c => c.Id)
            .HasDefaultValueSql("NEWID()");
    }
}
