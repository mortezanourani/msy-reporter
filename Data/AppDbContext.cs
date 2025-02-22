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

        modelBuilder.Entity<AthleticFacility>(e =>
        {
            e.Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");
        });

        modelBuilder.Entity<Champion>(e =>
        {
            e.Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");
        });

        modelBuilder.Entity<Championship>(e =>
        {
            e.Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");
        });

        modelBuilder.Entity<ChampionshipMedal>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new ChampionshipMedal { Id = 1, Name = "Gold", PersianName = "طلا" },
                new ChampionshipMedal { Id = 2, Name = "Silver", PersianName = "نقره" },
                new ChampionshipMedal { Id = 3, Name = "Bronze", PersianName = "برنز" }
            );
        });

        modelBuilder.Entity<City>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new City { Id = 1, Name = "Astara", PersianName = "آستارا" },
                new City { Id = 2, Name = "Astaneh", PersianName = "آستانه اشرفیه" },
                new City { Id = 3, Name = "Amlash", PersianName = "املش" },
                new City { Id = 4, Name = "Anzali", PersianName = "بندر انزلی" },
                new City { Id = 5, Name = "Khomam", PersianName = "خمام" },
                new City { Id = 6, Name = "Rasht", PersianName = "رشت" },
                new City { Id = 7, Name = "Rezvanshahr", PersianName = "رضوانشهر" },
                new City { Id = 8, Name = "Roudbar", PersianName = "رودبار" },
                new City { Id = 9, Name = "Roudsar", PersianName = "رودسر" },
                new City { Id = 10, Name = "Siahkal", PersianName = "سیاهکل" },
                new City { Id = 11, Name = "Shaft", PersianName = "شفت" },
                new City { Id = 12, Name = "Somehsara", PersianName = "صومعه سرا" },
                new City { Id = 13, Name = "Tavalesh", PersianName = "طوالش" },
                new City { Id = 14, Name = "Fouman", PersianName = "فومن" },
                new City { Id = 15, Name = "Lahijan", PersianName = "لاهیجان" },
                new City { Id = 16, Name = "Langaroud", PersianName = "لنگرود" },
                new City { Id = 17, Name = "Masal", PersianName = "ماسال" }
            );
        });

        modelBuilder.Entity<CourseParticipant>()
            .Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<FacilityGeoType>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new FacilityGeoType { Id = 1, Name = "City", PersianName = "شهری"},
                new FacilityGeoType { Id = 2, Name = "Village", PersianName = "روستایی"}
            );
        });

        modelBuilder.Entity<FacilityOwnership>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new FacilityOwnership { Id = 1, Name = "Governmental-MSY", PersianName = "دولتی - وزارت ورزش و جوانان" },
                new FacilityOwnership { Id = 2, Name = "Governmental-Others", PersianName = "دولتی - سایر ارگان ها" },
                new FacilityOwnership { Id = 3, Name = "People-Owned", PersianName = "باشگاه های خصوصی" }
            );
        });

        modelBuilder.Entity<FacilityStatus>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new FacilityStatus { Id = 1, Name = "Active", PersianName = "فعال" },
                new FacilityStatus { Id = 2, Name = "Inactive", PersianName = "غیرفعال" }
            );
        });

        modelBuilder.Entity<FacilityType>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new FacilityType {  Id = 1, Name = "Hall", PersianName = "سرپوشیده" },
                new FacilityType {  Id = 2, Name = "Land", PersianName = "روباز" }
            );
        });

        modelBuilder.Entity<FacilityUsersGender>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new FacilityUsersGender { Id = 1, Name = "Men", PersianName = "آقایان" },
                new FacilityUsersGender { Id = 2, Name = "Women", PersianName = "بانوان" },
                new FacilityUsersGender { Id = 3, Name = "Mix", PersianName = "مشترک" }
            );
        });

        modelBuilder.Entity<Federation>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new Federation { Id = Guid.NewGuid(), Name = "اتومبیلرانی و موتورسواری", PersianName = "اتومبیلرانی و موتورسواری" },
                new Federation { Id = Guid.NewGuid(), Name = "اسکواش", PersianName = "اسکواش" },
                new Federation { Id = Guid.NewGuid(), Name = "اسکی", PersianName = "اسکی" },
                new Federation { Id = Guid.NewGuid(), Name = "اسکیت", PersianName = "اسکیت" },
                new Federation { Id = Guid.NewGuid(), Name = "انجمن های ورزش های رزمی", PersianName = "انجمن های ورزش های رزمی" },
                new Federation { Id = Guid.NewGuid(), Name = "انجمن‌های ورزشی", PersianName = "انجمن‌های ورزشی" },
                new Federation { Id = Guid.NewGuid(), Name = "آمادگی جسمانی", PersianName = "آمادگی جسمانی" },
                new Federation { Id = Guid.NewGuid(), Name = "بدمینتون", PersianName = "بدمینتون" },
                new Federation { Id = Guid.NewGuid(), Name = "بدنسازی و پرورش اندام", PersianName = "بدنسازی و پرورش اندام" },
                new Federation { Id = Guid.NewGuid(), Name = "بسکتبال", PersianName = "بسکتبال" },
                new Federation { Id = Guid.NewGuid(), Name = "بوکس", PersianName = "بوکس" },
                new Federation { Id = Guid.NewGuid(), Name = "بولینگ، بیلیارد و بولس", PersianName = "بولینگ، بیلیارد و بولس" },
                new Federation { Id = Guid.NewGuid(), Name = "پزشکی ورزشی", PersianName = "پزشکی ورزشی" },
                new Federation { Id = Guid.NewGuid(), Name = "تکواندو", PersianName = "تکواندو" },
                new Federation { Id = Guid.NewGuid(), Name = "تنیس", PersianName = "تنیس" },
                new Federation { Id = Guid.NewGuid(), Name = "تنیس روی میز", PersianName = "تنیس روی میز" },
                new Federation { Id = Guid.NewGuid(), Name = "تیراندازی", PersianName = "تیراندازی" },
                new Federation { Id = Guid.NewGuid(), Name = "تیراندازی با کمان", PersianName = "تیراندازی با کمان" },
                new Federation { Id = Guid.NewGuid(), Name = "جودو", PersianName = "جودو" },
                new Federation { Id = Guid.NewGuid(), Name = "چوگان", PersianName = "چوگان" },
                new Federation { Id = Guid.NewGuid(), Name = "دو و میدانی", PersianName = "دو و میدانی" },
                new Federation { Id = Guid.NewGuid(), Name = "دوچرخه سواری", PersianName = "دوچرخه سواری" },
                new Federation { Id = Guid.NewGuid(), Name = "ژیمناستیک", PersianName = "ژیمناستیک" },
                new Federation { Id = Guid.NewGuid(), Name = "سه گانه", PersianName = "سه گانه" },
                new Federation { Id = Guid.NewGuid(), Name = "سوارکاری", PersianName = "سوارکاری" },
                new Federation { Id = Guid.NewGuid(), Name = "شطرنج", PersianName = "شطرنج" },
                new Federation { Id = Guid.NewGuid(), Name = "شمشیربازی", PersianName = "شمشیربازی" },
                new Federation { Id = Guid.NewGuid(), Name = "شنا، شیرجه و واترپلو", PersianName = "شنا، شیرجه و واترپلو" },
                new Federation { Id = Guid.NewGuid(), Name = "فوتبال", PersianName = "فوتبال" },
                new Federation { Id = Guid.NewGuid(), Name = "قایقرانی", PersianName = "قایقرانی" },
                new Federation { Id = Guid.NewGuid(), Name = "کاراته", PersianName = "کاراته" },
                new Federation { Id = Guid.NewGuid(), Name = "کبدی", PersianName = "کبدی" },
                new Federation { Id = Guid.NewGuid(), Name = "کشتی", PersianName = "کشتی" },
                new Federation { Id = Guid.NewGuid(), Name = "کونگ فو و هنرهای رزمی", PersianName = "کونگ فو و هنرهای رزمی" },
                new Federation { Id = Guid.NewGuid(), Name = "کوهنوردی و صعود ورزشی", PersianName = "کوهنوردی و صعود ورزشی" },
                new Federation { Id = Guid.NewGuid(), Name = "گلف", PersianName = "گلف" },
                new Federation { Id = Guid.NewGuid(), Name = "نجات غریق و غواصی", PersianName = "نجات غریق و غواصی" },
                new Federation { Id = Guid.NewGuid(), Name = "هاکی", PersianName = "هاکی" },
                new Federation { Id = Guid.NewGuid(), Name = "هندبال", PersianName = "هندبال" },
                new Federation { Id = Guid.NewGuid(), Name = "والیبال", PersianName = "والیبال" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش باستانی و پهلوانی", PersianName = "ورزش باستانی و پهلوانی" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش روستائی و بازی های بومی", PersianName = "ورزش روستائی و بازی های بومی" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های بیماریهای خاص", PersianName = "ورزش های بیماریهای خاص" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های جانبازان و توانیابان", PersianName = "ورزش های جانبازان و توانیابان" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های نابینایان و کم بینایان", PersianName = "ورزش های نابینایان و کم بینایان" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های ناشنوایان و کم شنوایان", PersianName = "ورزش های ناشنوایان و کم شنوایان" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های همگانی", PersianName = "ورزش های همگانی" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های دانش‌آموزی", PersianName = "ورزش های دانش‌آموزی" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های دانشگاهی", PersianName = "ورزش های دانشگاهی" },
                new Federation { Id = Guid.NewGuid(), Name = "ورزش های کارگری", PersianName = "ورزش های کارگری" },
                new Federation { Id = Guid.NewGuid(), Name = "وزنه برداری", PersianName = "وزنه برداری" },
                new Federation { Id = Guid.NewGuid(), Name = "ووشو", PersianName = "ووشو" }
            );
        });

        modelBuilder.Entity<FederationPresident>()
            .Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<Gender>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new Gender { Id = 1, Name = "Male", PersianName = "آقایان" },
                new Gender { Id = 2, Name = "Female", PersianName = "بانوان" }
            );
        });

        modelBuilder.Entity<M5BuildingOwnership>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new M5BuildingOwnership { Id = 1, Name = "Owned", PersianName = "تملیکی" },
                new M5BuildingOwnership { Id = 2, Name = "Rented", PersianName = "استیجاری" }
            );
        });

        modelBuilder.Entity<M5License>()
            .Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<M5LicenseStatus>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new M5LicenseStatus { Id = 1, Name = "Active", PersianName = "فعال" },
                new M5LicenseStatus { Id = 2, Name = "Expired", PersianName = "منقضی" }
            );
        });

        modelBuilder.Entity<M5LicenseType>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new M5LicenseType { Id = 1, Name = "Personal", PersianName = "حقیقی" },
                new M5LicenseType { Id = 2, Name = "Company", PersianName = "حقوقی" }
            );
        });

        modelBuilder.Entity<M88Contract>()
            .Property(m => m.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<SportsCourse>()
            .Property(c => c.Id)
            .HasDefaultValueSql("NEWID()");

        modelBuilder.Entity<SportsCourseType>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new SportsCourseType { Id = 1, Name = "Coaching", PersianName = "مربیگری" },
                new SportsCourseType { Id = 2, Name = "Referee", PersianName = "داوری" }
            );
        });

        modelBuilder.Entity<SportsCourseGrade>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new SportsCourseGrade { Id = 1, Name = "A", PersianName = "درجه یک" },
                new SportsCourseGrade { Id = 2, Name = "b", PersianName = "درجه دو" },
                new SportsCourseGrade { Id = 3, Name = "C", PersianName = "درجه سه" }
            );
        });

        modelBuilder.Entity<TournamentAgeGroup>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new TournamentAgeGroup { Id = 1, Name = "1", PersianName = "نونهالان" },
                new TournamentAgeGroup { Id = 2, Name = "2", PersianName = "خردسالان" },
                new TournamentAgeGroup { Id = 3, Name = "3", PersianName = "زیر 14 سال" },
                new TournamentAgeGroup { Id = 4, Name = "4", PersianName = "نوجوانان" },
                new TournamentAgeGroup { Id = 5, Name = "5", PersianName = "زیر 23 سال" },
                new TournamentAgeGroup { Id = 6, Name = "6", PersianName = "جوانان" },
                new TournamentAgeGroup { Id = 7, Name = "7", PersianName = "بزرگسالان" },
                new TournamentAgeGroup { Id = 8, Name = "8", PersianName = "پیشکسوتان" }
            );
        });

        modelBuilder.Entity<TournamentLevel>(e =>
        {
            e.Property(m => m.Id)
            .ValueGeneratedOnAdd();

            e.HasData(
                new TournamentLevel { Id = 1, Name = "1", PersianName = "بین المللی" },
                new TournamentLevel { Id = 2, Name = "2", PersianName = "آسیایی" },
                new TournamentLevel { Id = 3, Name = "3", PersianName = "جهانی" },
                new TournamentLevel { Id = 4, Name = "4", PersianName = "المپیک" },
                new TournamentLevel { Id = 5, Name = "5", PersianName = "المپیک دانشجویان" },
                new TournamentLevel { Id = 6, Name = "6", PersianName = "اوراسیا" },
                new TournamentLevel { Id = 7, Name = "7", PersianName = "کشورهای اسلامی" },
                new TournamentLevel { Id = 8, Name = "8", PersianName = "بازی های آسیایی" },
                new TournamentLevel { Id = 9, Name = "9", PersianName = "ملی" }
            );
        });
    }
}
