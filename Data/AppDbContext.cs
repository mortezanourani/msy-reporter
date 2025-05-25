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

    public virtual DbSet<Athlete> Athletes { get; set; }

    public virtual DbSet<Champion> Champions { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<ConstructionProject> ConstructionProjects { get; set; }

    public virtual DbSet<Facility> Facilities { get; set; }

    public virtual DbSet<FacilityContract> FacilityContracts { get; set; }

    public virtual DbSet<FacilityDocument> FacilityDocuments { get; set; }

    public virtual DbSet<FacilityType> FacilityTypes { get; set; }

    public virtual DbSet<Federation> Federations { get; set; }

    public virtual DbSet<FundingSource> FundingSources { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<GovernmentFacility> GovernmentFacilities { get; set; }

    public virtual DbSet<GovernmentFacilityLicense> GovernmentFacilityLicenses { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<LocalFederation> LocalFederations { get; set; }

    public virtual DbSet<LocalFederationPresident> LocalFederationPresidents { get; set; }

    public virtual DbSet<Medal> Medals { get; set; }

    public virtual DbSet<PrivateFacility> PrivateFacilities { get; set; }

    public virtual DbSet<PrivateFacilityLicense> PrivateFacilityLicenses { get; set; }

    public virtual DbSet<ProjectBudget> ProjectBudgets { get; set; }

    public virtual DbSet<ProjectProgress> ProjectProgresses { get; set; }

    public virtual DbSet<ProjectType> ProjectTypes { get; set; }

    public virtual DbSet<Tournament> Tournaments { get; set; }

    public virtual DbSet<TournamentLevel> TournamentLevels { get; set; }

    public virtual DbSet<UsersGender> UsersGenders { get; set; }

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

        modelBuilder.Entity<Athlete>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.SeenCode).HasMaxLength(10);

            entity.HasOne(d => d.City).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Gender).WithMany(p => p.Athletes)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Champion>(entity =>
        {
            entity.HasIndex(e => new { e.AthleteId, e.TournamentId, e.Field, e.MedalId }, "IX_Champions").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Field).HasMaxLength(256);

            entity.HasOne(d => d.AgeGroup).WithMany(p => p.Champions)
                .HasForeignKey(d => d.AgeGroupId)
                .HasConstraintName("FK_Tournaments_AgeGroups_AgeGroupId");

            entity.HasOne(d => d.Athlete).WithMany(p => p.Champions)
                .HasForeignKey(d => d.AthleteId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Medal).WithMany(p => p.Champions).HasForeignKey(d => d.MedalId);

            entity.HasOne(d => d.Tournament).WithMany(p => p.Champions)
                .HasForeignKey(d => d.TournamentId)
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
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Facility).WithMany(p => p.ConstructionProjects).HasForeignKey(d => d.FacilityId);

            entity.HasOne(d => d.Type).WithMany(p => p.ConstructionProjects).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Facility>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.City).WithMany(p => p.Facilities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.Facilities).HasForeignKey(d => d.TypeId);

            entity.HasOne(d => d.UsersGender).WithMany(p => p.Facilities)
                .HasForeignKey(d => d.UsersGenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<FacilityContract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FacilitiesContracts");

            entity.HasIndex(e => e.Serial, "IX_FacilityContracts_Serial")
                .IsUnique()
                .HasFilter("([Serial] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ExpireDate).HasMaxLength(10);
            entity.Property(e => e.LicenseDate).HasMaxLength(10);
            entity.Property(e => e.LicenseSerial).HasMaxLength(256);
            entity.Property(e => e.Serial).HasMaxLength(256);
            entity.Property(e => e.StartDate).HasMaxLength(10);

            entity.HasOne(d => d.Facility).WithMany(p => p.FacilityContracts)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FacilitiesContracts_Facilities_FacilityId");

            entity.HasOne(d => d.LegalContractor).WithMany(p => p.FacilityContracts)
                .HasForeignKey(d => d.LegalContractorId)
                .HasConstraintName("FK_FacilityContractLicenses_LocalFederations_LegalContractorId");
        });

        modelBuilder.Entity<FacilityDocument>(entity =>
        {
            entity.HasIndex(e => e.Serial, "IX_FacilityDocuments_Serial")
                .IsUnique()
                .HasFilter("([Serial] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Date).HasMaxLength(10);
            entity.Property(e => e.IsNew).HasDefaultValue(true);
            entity.Property(e => e.Serial).HasMaxLength(32);

            entity.HasOne(d => d.Facility).WithMany(p => p.FacilityDocuments).HasForeignKey(d => d.FacilityId);
        });

        modelBuilder.Entity<FacilityType>(entity =>
        {
            entity.HasIndex(e => e.NormalizedType, "IX_FacilityTypes_Type").IsUnique();

            entity.Property(e => e.NormalizedType)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Type]))", false);
            entity.Property(e => e.PersianTitle).HasMaxLength(256);
            entity.Property(e => e.Type).HasMaxLength(256);
        });

        modelBuilder.Entity<Federation>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_Federations_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        modelBuilder.Entity<FundingSource>(entity =>
        {
            entity.HasIndex(e => e.NormalizedTitle, "IX_FundingSources").IsUnique();

            entity.Property(e => e.NormalizedTitle)
                .HasMaxLength(16)
                .HasComputedColumnSql("(upper([Title]))", false);
            entity.Property(e => e.Title).HasMaxLength(16);
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

        modelBuilder.Entity<GovernmentFacility>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.City).WithMany(p => p.GovernmentFacilities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.GovernmentFacilities).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<GovernmentFacilityLicense>(entity =>
        {
            entity.HasIndex(e => e.Serial, "IX_GovernmentFacilityLicenses_Serial")
                .IsUnique()
                .HasFilter("([Serial] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ExpireDate).HasMaxLength(10);
            entity.Property(e => e.Serial).HasMaxLength(256);
            entity.Property(e => e.StartDate).HasMaxLength(10);

            entity.HasOne(d => d.Facility).WithMany(p => p.GovernmentFacilityLicenses)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UsersGender).WithMany(p => p.GovernmentFacilityLicenses)
                .HasForeignKey(d => d.UsersGenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GovernmentFacilities_UsersGenders_UsersGenderId");
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

        modelBuilder.Entity<LocalFederation>(entity =>
        {
            entity.HasIndex(e => new { e.FederationId, e.CityId, e.District }, "IX_LocalFederations_Index").IsUnique();

            entity.HasIndex(e => e.NationalId, "IX_LocalFederations_NationalId")
                .IsUnique()
                .HasFilter("([NationalId] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.District).HasMaxLength(16);
            entity.Property(e => e.NationalId).HasMaxLength(16);

            entity.HasOne(d => d.City).WithMany(p => p.LocalFederations)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Federation).WithMany(p => p.LocalFederations)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<LocalFederationPresident>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_FederationPresidents");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Federation).WithMany(p => p.LocalFederationPresidents)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FederationPresidents_LocalFederations_FederationId");
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

        modelBuilder.Entity<PrivateFacility>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);

            entity.HasOne(d => d.City).WithMany(p => p.PrivateFacilities)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Type).WithMany(p => p.PrivateFacilities).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<PrivateFacilityLicense>(entity =>
        {
            entity.HasIndex(e => e.Serial, "IX_PrivateFacilityLicenses_Serial")
                .IsUnique()
                .HasFilter("([Serial] IS NOT NULL)");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.ExpireDate).HasMaxLength(10);
            entity.Property(e => e.IsBeneficial).HasDefaultValue(true);
            entity.Property(e => e.Serial).HasMaxLength(256);
            entity.Property(e => e.StartDate).HasMaxLength(10);

            entity.HasOne(d => d.Facility).WithMany(p => p.PrivateFacilityLicenses)
                .HasForeignKey(d => d.FacilityId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.UsersGender).WithMany(p => p.PrivateFacilityLicenses)
                .HasForeignKey(d => d.UsersGenderId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProjectBudget>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.Year, e.SourceId });

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectBudgets)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Source).WithMany(p => p.ProjectBudgets)
                .HasForeignKey(d => d.SourceId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProjectProgress>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.Year, e.Month });

            entity.ToTable("ProjectProgress");

            entity.Property(e => e.CompletionBudget).HasDefaultValue(0);
            entity.Property(e => e.ContractorUnpaid).HasDefaultValue(0);

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectProgresses)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<ProjectType>(entity =>
        {
            entity.HasIndex(e => e.NormalizedTitle, "IX_ProjectTypes").IsUnique();

            entity.Property(e => e.NormalizedTitle)
                .HasMaxLength(16)
                .HasComputedColumnSql("(upper([Title]))", false);
            entity.Property(e => e.Title).HasMaxLength(16);
        });

        modelBuilder.Entity<Tournament>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Federation).WithMany(p => p.Tournaments)
                .HasForeignKey(d => d.FederationId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Level).WithMany(p => p.Tournaments)
                .HasForeignKey(d => d.LevelId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<TournamentLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TournamentLevelsLevels");

            entity.HasIndex(e => e.NormalizedTitle, "IX_TournamentLevelsLevels_Title").IsUnique();

            entity.Property(e => e.NormalizedTitle)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Title]))", false);
            entity.Property(e => e.PersianTitle).HasMaxLength(256);
            entity.Property(e => e.Title).HasMaxLength(256);
        });

        modelBuilder.Entity<UsersGender>(entity =>
        {
            entity.HasIndex(e => e.NormalizedName, "IX_UsersGenders_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(256);
            entity.Property(e => e.NormalizedName)
                .HasMaxLength(256)
                .HasComputedColumnSql("(upper([Name]))", false);
            entity.Property(e => e.PersianName).HasMaxLength(256);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
