using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<AthleticFacility> AthleticFacilities { get; set; }
    public DbSet<Champion> Champions { get; set; }
    public DbSet<Championship> Championships { get; set;}
    public DbSet<ChampionshipMedal> ChampionshipMedals { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<CourseParticipant> CourseParticipants { get; set; }
    public DbSet<FacilityGeoType> FacilityGeoTypes { get; set; }
    public DbSet<FacilityOwnership> FacilityOwnerships { get; set; }
    public DbSet<FacilityStatus> FacilityStatuses { get; set; }
    public DbSet<FacilityType> FacilityTypes { get; set; }
    public DbSet<FacilityUsersGender> FacilityUsersGenders { get; set; }
    public DbSet<Federation> Federations { get; set; }
    public DbSet<FederationPresident> FederationPresidents { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<M5BuildingOwnership> M5BuildingOwnerships { get; set; }
    public DbSet<M5License> M5Licenses { get; set; }
    public DbSet<M5LicenseStatus> M5LicenseStatuses { get; set; }
    public DbSet<M5LicenseType> M5LicenseTypes { get; set; }
    public DbSet<M88Contract> M88Contracts { get; set; }
    public DbSet<SportsCourse> SportsCourses { get; set; }
    public DbSet<SportsCourseGrade> SportsCourseGrades { get; set; }
    public DbSet<SportsCourseType> SportsCourseTypes { get; set; }
    public DbSet<TournamentAgeGroup> TournamentAgeGroups { get; set; }
    public DbSet<TournamentLevel> TournamentLevels { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AthleticFacility>(f =>
        {
            f.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");
        });

        modelBuilder.Entity<M88Contract>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<M5License>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Federation>(f =>
        {
            f.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            f.HasData(
                new Federation { Id = 1, City = null, Name = "اتومبیلرانی و موتورسواری" },
                new Federation { Id = 2, City = null, Name = "اسکواش" },
                new Federation { Id = 3, City = null, Name = "اسکی" },
                new Federation { Id = 4, City = null, Name = "اسکیت" },
                new Federation { Id = 5, City = null, Name = "انجمن های ورزش های رزمی" },
                new Federation { Id = 6, City = null, Name = "انجمن‌های ورزشی" },
                new Federation { Id = 7, City = null, Name = "آمادگی جسمانی" },
                new Federation { Id = 8, City = null, Name = "بدمینتون" },
                new Federation { Id = 9, City = null, Name = "بدنسازی و پرورش اندام" },
                new Federation { Id = 10, City = null, Name = "بسکتبال" },
                new Federation { Id = 11, City = null, Name = "بوکس" },
                new Federation { Id = 12, City = null, Name = "بولینگ، بیلیارد و بولس" },
                new Federation { Id = 13, City = null, Name = "پزشکی ورزشی" },
                new Federation { Id = 14, City = null, Name = "تکواندو" },
                new Federation { Id = 15, City = null, Name = "تنیس" },
                new Federation { Id = 16, City = null, Name = "تنیس روی میز" },
                new Federation { Id = 17, City = null, Name = "تیراندازی" },
                new Federation { Id = 18, City = null, Name = "تیراندازی با کمان" },
                new Federation { Id = 19, City = null, Name = "جودو" },
                new Federation { Id = 20, City = null, Name = "چوگان" },
                new Federation { Id = 21, City = null, Name = "دو و میدانی" },
                new Federation { Id = 22, City = null, Name = "دوچرخه سواری" },
                new Federation { Id = 23, City = null, Name = "ژیمناستیک" },
                new Federation { Id = 24, City = null, Name = "سه گانه" },
                new Federation { Id = 25, City = null, Name = "سوارکاری" },
                new Federation { Id = 26, City = null, Name = "شطرنج" },
                new Federation { Id = 27, City = null, Name = "شمشیربازی" },
                new Federation { Id = 28, City = null, Name = "شنا، شیرجه و واترپلو" },
                new Federation { Id = 29, City = null, Name = "فوتبال" },
                new Federation { Id = 30, City = null, Name = "قایقرانی" },
                new Federation { Id = 31, City = null, Name = "کاراته" },
                new Federation { Id = 32, City = null, Name = "کبدی" },
                new Federation { Id = 33, City = null, Name = "کشتی" },
                new Federation { Id = 34, City = null, Name = "کونگ فو و هنرهای رزمی" },
                new Federation { Id = 35, City = null, Name = "کوهنوردی و صعود ورزشی" },
                new Federation { Id = 36, City = null, Name = "گلف" },
                new Federation { Id = 37, City = null, Name = "نجات غریق و غواصی" },
                new Federation { Id = 38, City = null, Name = "هاکی" },
                new Federation { Id = 39, City = null, Name = "هندبال" },
                new Federation { Id = 40, City = null, Name = "والیبال" },
                new Federation { Id = 41, City = null, Name = "ورزش باستانی و پهلوانی" },
                new Federation { Id = 42, City = null, Name = "ورزش روستائی و بازی های بومی" },
                new Federation { Id = 43, City = null, Name = "ورزش های بیماریهای خاص" },
                new Federation { Id = 44, City = null, Name = "ورزش های جانبازان و توانیابان" },
                new Federation { Id = 45, City = null, Name = "ورزش های نابینایان و کم بینایان" },
                new Federation { Id = 46, City = null, Name = "ورزش های ناشنوایان و کم شنوایان" },
                new Federation { Id = 47, City = null, Name = "ورزش های همگانی" },
                new Federation { Id = 48, City = null, Name = "ورزش های دانش‌آموزی" },
                new Federation { Id = 49, City = null, Name = "ورزش های دانشگاهی" },
                new Federation { Id = 50, City = null, Name = "ورزش های کارگری" },
                new Federation { Id = 51, City = null, Name = "وزنه برداری" },
                new Federation { Id = 52, City = null, Name = "ووشو" }
            );
        });

        modelBuilder.Entity<SportsCourse>()
            .Property(c => c.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Champion>()
            .Property(c => c.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Championship>()
            .Property(c => c.Id)
            .HasDefaultValueSql("NEWID()");
    }
}
