using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Reporter.Data;

namespace Reporter.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<AgeGroup> AgeGroups { get; set; }

        public virtual DbSet<Athlete> Athletes { get; set; }

        public virtual DbSet<Champion> Champions { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<ConstructionProject> ConstructionProjects { get; set; }

        public virtual DbSet<Course> Courses { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<EmploymentType> EmploymentTypes { get; set; }

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
        public DbSet<Reporter.Data.Population> Population { get; set; } = default!;
    }
}
