using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Reporter.Models;

namespace Reporter.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgeGroup> AgeGroups { get; set; }

    public virtual DbSet<AthleticFacility> AthleticFacilities { get; set; }

    public virtual DbSet<Champion> Champions { get; set; }

    public virtual DbSet<Championship> Championships { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ConstructionProject> ConstructionProjects { get; set; }

    public virtual DbSet<EventLevel> EventLevels { get; set; }

    public virtual DbSet<FacilityType> FacilityTypes { get; set; }

    public virtual DbSet<Federation> Federations { get; set; }

    public virtual DbSet<FederationMeeting> FederationMeetings { get; set; }

    public virtual DbSet<FederationPresident> FederationPresidents { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<InviteeRole> InviteeRoles { get; set; }

    public virtual DbSet<LegalTitle> LegalTitles { get; set; }

    public virtual DbSet<M5license> M5licenses { get; set; }

    public virtual DbSet<M88contract> M88contracts { get; set; }

    public virtual DbSet<Medal> Medals { get; set; }

    public virtual DbSet<MeetingType> MeetingTypes { get; set; }

    public virtual DbSet<MeetingVote> MeetingVotes { get; set; }

    public virtual DbSet<NationalTeamInvitee> NationalTeamInvitees { get; set; }

    public virtual DbSet<Ownership> Ownerships { get; set; }

    public virtual DbSet<ProjectBudget> ProjectBudgets { get; set; }

    public virtual DbSet<ProjectCompletionProgress> ProjectCompletionProgresses { get; set; }

    public virtual DbSet<Record> Records { get; set; }

    public virtual DbSet<SportsCourse> SportsCourses { get; set; }

    public virtual DbSet<SportsCourseGrade> SportsCourseGrades { get; set; }

    public virtual DbSet<SportsCourseParticipant> SportsCourseParticipants { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Persian_100_CI_AI");

        modelBuilder.Entity<AgeGroup>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_AgeGroups_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<AthleticFacility>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.City).WithMany(p => p.AthleticFacilities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ownership).WithMany(p => p.AthleticFacilities)
                .HasForeignKey(d => d.OwnershipId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.AthleticFacilities).HasForeignKey(d => d.TypeId);

            entity.HasMany(d => d.Genders).WithMany(p => p.Facilities)
                .UsingEntity<Dictionary<string, object>>(
                    "FacilityUserGeneder",
                    r => r.HasOne<Gender>().WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FacilityUserGenders_Genders_GenderId"),
                    l => l.HasOne<AthleticFacility>().WithMany()
                        .HasForeignKey("FacilityId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_FacilityUserGenders_AthleticFacilities_FacilityId"),
                    j =>
                    {
                        j.HasKey("FacilityId", "GenderId").HasName("PK_FacilityUserGenders");
                        j.ToTable("FacilityUserGeneders");
                    });
        });

        modelBuilder.Entity<Champion>(entity =>
        {
            entity.HasIndex(e => e.SeenCode, "FK_Champions_SeenCode").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SeenCode).HasMaxLength(10);

            entity.HasOne(d => d.City).WithMany(p => p.Champions)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_Champions_Cities_City_Id");

            entity.HasOne(d => d.Gender).WithMany(p => p.Champions)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.Championships).WithMany(p => p.Champions)
                .UsingEntity<Dictionary<string, object>>(
                    "ChampionChampionship",
                    r => r.HasOne<Championship>().WithMany()
                        .HasForeignKey("ChampionshipId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ChampionChampionships_Championship_ChampionshipId"),
                    l => l.HasOne<Champion>().WithMany()
                        .HasForeignKey("ChampionId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("ChampionId", "ChampionshipId");
                        j.ToTable("ChampionChampionships");
                    });
        });

        modelBuilder.Entity<Championship>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AgeGroup).WithMany(p => p.Championships)
                .HasForeignKey(d => d.AgeGroupId)
                .HasConstraintName("FK_Championships_AgeGroups_AgeGroupsId");

            entity.HasOne(d => d.EventLevel).WithMany(p => p.Championships)
                .HasForeignKey(d => d.EventLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Federation).WithMany(p => p.Championships)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Medal).WithMany(p => p.Championships)
                .HasForeignKey(d => d.MedalId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_Cities_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<ConstructionProject>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Title).HasMaxLength(256);

            entity.HasOne(d => d.City).WithMany(p => p.ConstructionProjects)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Projects_Cities_CityId");

            entity.HasOne(d => d.Type).WithMany(p => p.ConstructionProjects)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.Genders).WithMany(p => p.Projects)
                .UsingEntity<Dictionary<string, object>>(
                    "ProjectUserGeneder",
                    r => r.HasOne<Gender>().WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProjectUserGenders_Genders_GenderId"),
                    l => l.HasOne<ConstructionProject>().WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProjectUserGenders_ConstructionProjects_ProjectId"),
                    j =>
                    {
                        j.HasKey("ProjectId", "GenderId").HasName("PK_ProjectUserGenders");
                        j.ToTable("ProjectUserGeneders");
                    });
        });

        modelBuilder.Entity<EventLevel>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_EventLevels_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<FacilityType>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_FacilityTypes_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<Federation>(entity =>
        {
            entity.HasIndex(e => new { e.CityId, e.NormalizedName }, "IX_Federations_Name").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);

            entity.HasOne(d => d.City).WithMany(p => p.Federations).HasForeignKey(d => d.CityId);
        });

        modelBuilder.Entity<FederationMeeting>(entity =>
        {
            entity.HasIndex(e => new { e.FederationId, e.TypeId, e.Year, e.Month, e.Day }, "IX_FederationMeetings").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Federation).WithMany(p => p.FederationMeetings)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.FederationMeetings)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FederationPresident>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Federation).WithMany(p => p.FederationPresidents)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_Genders_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasIndex(e => new { e.CityId, e.FederationId, e.GenderId, e.Year, e.Month }, "IX_Insurances").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.City).WithMany(p => p.Insurances)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Federation).WithMany(p => p.Insurances)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Gender).WithMany(p => p.Insurances)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<InviteeRole>(entity =>
        {
            entity.HasIndex(e => e.NormalizedRole, "IX_InviteeRoles").IsUnique();

            entity.Property(e => e.NormalizedRole)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Role]))", false);
            entity.Property(e => e.Role).HasMaxLength(256);
        });

        modelBuilder.Entity<LegalTitle>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_LegalTitles_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<M5license>(entity =>
        {
            entity.ToTable("M5Licenses");

            entity.HasIndex(e => e.Serial, "IX_M5Licenses_Serial").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Serial).HasMaxLength(256);

            entity.HasOne(d => d.Facility).WithMany(p => p.M5licenses)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.LegalTitle).WithMany(p => p.M5licenses).HasForeignKey(d => d.LegalTitleId);
        });

        modelBuilder.Entity<M88contract>(entity =>
        {
            entity.ToTable("M88Contracts");

            entity.HasIndex(e => e.Serial, "IX_M88Contracts_Serial").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.M5licenseId).HasColumnName("M5LicenseId");
            entity.Property(e => e.Serial).HasMaxLength(256);

            entity.HasOne(d => d.Facility).WithMany(p => p.M88contracts)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.M5license).WithMany(p => p.M88contracts).HasForeignKey(d => d.M5licenseId);
        });

        modelBuilder.Entity<Medal>(entity =>
        {
            entity.HasIndex(e => new { e.IsIndividualMedal, e.NormalizedColor }, "IX_Medals_Medal").IsUnique();

            entity.Property(e => e.Color).HasMaxLength(256);
            entity.Property(e => e.NormalizedColor)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Color]))", false);
            entity.Property(e => e.PersianTitle).HasMaxLength(256);
        });

        modelBuilder.Entity<MeetingType>(entity =>
        {
            entity.HasIndex(e => e.NormalizedType, "IX_MeetingTypes_Type").IsUnique();

            entity.Property(e => e.NormalizedType)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Type]))", false);
            entity.Property(e => e.PersianTitle).HasMaxLength(256);
            entity.Property(e => e.Type).HasMaxLength(256);
        });

        modelBuilder.Entity<MeetingVote>(entity =>
        {
            entity.HasKey(e => new { e.MeetingId, e.Name });

            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.Meeting).WithMany(p => p.MeetingVotes)
                .HasForeignKey(d => d.MeetingId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<NationalTeamInvitee>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.AgeGroup).WithMany(p => p.NationalTeamInvitees).HasForeignKey(d => d.AgeGroupId);

            entity.HasOne(d => d.Federation).WithMany(p => p.NationalTeamInvitees)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Gender).WithMany(p => p.NationalTeamInvitees)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Role).WithMany(p => p.NationalTeamInvitees)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Ownership>(entity =>
        {
            entity.HasIndex(e => new { e.IsGovernmentOwned, e.NormalizedType }, "IX_Ownerships_Type").IsUnique();

            entity.Property(e => e.NormalizedType)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Type]))", false);
            entity.Property(e => e.PersianTitle).HasMaxLength(256);
            entity.Property(e => e.Type).HasMaxLength(256);
        });

        modelBuilder.Entity<ProjectBudget>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.Year });

            entity.Property(e => e.CompletionBudget).HasDefaultValue(0);
            entity.Property(e => e.ContractorUnpaid).HasDefaultValue(0);

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectBudgets)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProjectCompletionProgress>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.Percentage });

            entity.ToTable("ProjectCompletionProgress");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectCompletionProgresses)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Record>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AgeGroup).WithMany(p => p.Records).HasForeignKey(d => d.AgeGroupId);

            entity.HasOne(d => d.City).WithMany(p => p.Records)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Federation).WithMany(p => p.Records)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<SportsCourse>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Federation).WithMany(p => p.SportsCourses)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Grade).WithMany(p => p.SportsCourses)
                .HasForeignKey(d => d.GradeId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasMany(d => d.Participants).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "SportsCourseCourseParticipant",
                    r => r.HasOne<SportsCourseParticipant>().WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SportsCourseCourseParticipants_SportsCourseParticipants_ParticipantsId"),
                    l => l.HasOne<SportsCourse>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull),
                    j =>
                    {
                        j.HasKey("CourseId", "ParticipantId");
                        j.ToTable("SportsCourseCourseParticipants");
                    });
        });

        modelBuilder.Entity<SportsCourseGrade>(entity =>
        {
            entity.HasIndex(e => e.NormalizedGrade, "IX_SportsCourseGrades_Grade").IsUnique();

            entity.Property(e => e.Grade).HasMaxLength(256);
            entity.Property(e => e.NormalizedGrade)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Grade]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<SportsCourseParticipant>(entity =>
        {
            entity.HasIndex(e => e.SeenCode, "IX_SportsCourseParticipants_SeenCode").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.SeenCode).HasMaxLength(10);

            entity.HasOne(d => d.Gender).WithMany(p => p.SportsCourseParticipants)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
