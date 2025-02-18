using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<SportFacility> SportFacilities { get; set; }

    public DbSet<SportFacilityContract> M88Contracts { get; set; }

    public DbSet<SportFacilityLicense> M5Licenses { get; set; }
    
    public DbSet<Federation> Federations { get; set; }
    
    public DbSet<SportCourse> SportCourses { get; set; }

    public DbSet<SportCourseParticipant> SportCourseParticipants { get; set; }

    public DbSet<Champion> Champions { get; set; }

    public DbSet<Championship> Championships { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SportFacility>(f =>
        {
            f.Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

            f.Property(e => e.Edited)
            .HasDefaultValueSql("GETDATE()");
        });

        modelBuilder.Entity<SportFacilityContract>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<SportFacilityLicense>()
            .Property(e => e.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Federation>(f =>
        {
            f.Property(e => e.Id)
            .ValueGeneratedOnAdd();

            f.HasData(
                new Federation { Id = 1, City = 0, Name = "اتومبیلرانی و موتورسواری" },
                new Federation { Id = 2, City = 0, Name = "اسکواش" },
                new Federation { Id = 3, City = 0, Name = "اسکی" },
                new Federation { Id = 4, City = 0, Name = "اسکیت" },
                new Federation { Id = 5, City = 0, Name = "انجمن های ورزش های رزمی" },
                new Federation { Id = 6, City = 0, Name = "انجمن‌های ورزشی" },
                new Federation { Id = 7, City = 0, Name = "آمادگی جسمانی" },
                new Federation { Id = 8, City = 0, Name = "بدمینتون" },
                new Federation { Id = 9, City = 0, Name = "بدنسازی و پرورش اندام" },
                new Federation { Id = 10, City = 0, Name = "بسکتبال" },
                new Federation { Id = 11, City = 0, Name = "بوکس" },
                new Federation { Id = 12, City = 0, Name = "بولینگ، بیلیارد و بولس" },
                new Federation { Id = 13, City = 0, Name = "پزشکی ورزشی" },
                new Federation { Id = 14, City = 0, Name = "تکواندو" },
                new Federation { Id = 15, City = 0, Name = "تنیس" },
                new Federation { Id = 16, City = 0, Name = "تنیس روی میز" },
                new Federation { Id = 17, City = 0, Name = "تیراندازی" },
                new Federation { Id = 18, City = 0, Name = "تیراندازی با کمان" },
                new Federation { Id = 19, City = 0, Name = "جودو" },
                new Federation { Id = 20, City = 0, Name = "چوگان" },
                new Federation { Id = 21, City = 0, Name = "دو و میدانی" },
                new Federation { Id = 22, City = 0, Name = "دوچرخه سواری" },
                new Federation { Id = 23, City = 0, Name = "ژیمناستیک" },
                new Federation { Id = 24, City = 0, Name = "سه گانه" },
                new Federation { Id = 25, City = 0, Name = "سوارکاری" },
                new Federation { Id = 26, City = 0, Name = "شطرنج" },
                new Federation { Id = 27, City = 0, Name = "شمشیربازی" },
                new Federation { Id = 28, City = 0, Name = "شنا، شیرجه و واترپلو" },
                new Federation { Id = 29, City = 0, Name = "فوتبال" },
                new Federation { Id = 30, City = 0, Name = "قایقرانی" },
                new Federation { Id = 31, City = 0, Name = "کاراته" },
                new Federation { Id = 32, City = 0, Name = "کبدی" },
                new Federation { Id = 33, City = 0, Name = "کشتی" },
                new Federation { Id = 34, City = 0, Name = "کونگ فو و هنرهای رزمی" },
                new Federation { Id = 35, City = 0, Name = "کوهنوردی و صعود ورزشی" },
                new Federation { Id = 36, City = 0, Name = "گلف" },
                new Federation { Id = 37, City = 0, Name = "نجات غریق و غواصی" },
                new Federation { Id = 38, City = 0, Name = "هاکی" },
                new Federation { Id = 39, City = 0, Name = "هندبال" },
                new Federation { Id = 40, City = 0, Name = "والیبال" },
                new Federation { Id = 41, City = 0, Name = "ورزش باستانی و پهلوانی" },
                new Federation { Id = 42, City = 0, Name = "ورزش روستائی و بازی های بومی" },
                new Federation { Id = 43, City = 0, Name = "ورزش های بیماریهای خاص" },
                new Federation { Id = 44, City = 0, Name = "ورزش های جانبازان و توانیابان" },
                new Federation { Id = 45, City = 0, Name = "ورزش های نابینایان و کم بینایان" },
                new Federation { Id = 46, City = 0, Name = "ورزش های ناشنوایان و کم شنوایان" },
                new Federation { Id = 47, City = 0, Name = "ورزش های همگانی" },
                new Federation { Id = 48, City = 0, Name = "ورزش های دانش‌آموزی" },
                new Federation { Id = 49, City = 0, Name = "ورزش های دانشگاهی" },
                new Federation { Id = 50, City = 0, Name = "ورزش های کارگری" },
                new Federation { Id = 51, City = 0, Name = "وزنه برداری" },
                new Federation { Id = 52, City = 0, Name = "ووشو" }
            );
        });

        modelBuilder.Entity<SportCourse>()
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
