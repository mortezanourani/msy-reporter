using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reporter.Data.Migrations
{
    /// <inheritdoc />
    public partial class AppInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChampionshipMedals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChampionshipMedals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityGeoTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityGeoTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityOwnerships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityOwnerships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FacilityUsersGenders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityUsersGenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M5BuildingOwnerships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M5BuildingOwnerships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M5LicenseStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M5LicenseStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M5LicenseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M5LicenseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportsCourseGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsCourseGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SportsCourseTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsCourseTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentAgeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentAgeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TournamentLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Federations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Federations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Federations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AthleticFacilities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnershipId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    GeoTypeId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<float>(type: "real", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    UsersGenderId = table.Column<int>(type: "int", nullable: true),
                    Sports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AthleticFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_FacilityGeoTypes_GeoTypeId",
                        column: x => x.GeoTypeId,
                        principalTable: "FacilityGeoTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_FacilityOwnerships_OwnershipId",
                        column: x => x.OwnershipId,
                        principalTable: "FacilityOwnerships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_FacilityStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "FacilityStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_FacilityTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "FacilityTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AthleticFacilities_FacilityUsersGenders_UsersGenderId",
                        column: x => x.UsersGenderId,
                        principalTable: "FacilityUsersGenders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FederationPresidents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeedCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FederationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FederationPresidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FederationPresidents_Federations_FederationId",
                        column: x => x.FederationId,
                        principalTable: "Federations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SportsCourses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    FederationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportsCourses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportsCourses_Federations_FederationId",
                        column: x => x.FederationId,
                        principalTable: "Federations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportsCourses_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportsCourses_SportsCourseGrades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "SportsCourseGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportsCourses_SportsCourseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "SportsCourseTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M5Licenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    AthleticFicilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    OwnershipId = table.Column<int>(type: "int", nullable: true),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ExpireDate = table.Column<DateOnly>(type: "date", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeenCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M5Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M5Licenses_AthleticFacilities_AthleticFicilityId",
                        column: x => x.AthleticFicilityId,
                        principalTable: "AthleticFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M5Licenses_M5BuildingOwnerships_OwnershipId",
                        column: x => x.OwnershipId,
                        principalTable: "M5BuildingOwnerships",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_M5Licenses_M5LicenseStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "M5LicenseStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_M5Licenses_M5LicenseTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "M5LicenseTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Championships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FederationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroupId = table.Column<int>(type: "int", nullable: true),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedalId = table.Column<int>(type: "int", nullable: false),
                    ChampionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Championships_Champions_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Championships_ChampionshipMedals_MedalId",
                        column: x => x.MedalId,
                        principalTable: "ChampionshipMedals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Championships_Federations_FederationId",
                        column: x => x.FederationId,
                        principalTable: "Federations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Championships_TournamentAgeGroups_AgeGroupId",
                        column: x => x.AgeGroupId,
                        principalTable: "TournamentAgeGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Championships_TournamentLevels_LevelId",
                        column: x => x.LevelId,
                        principalTable: "TournamentLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseParticipants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeenCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SportsCourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseParticipants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseParticipants_SportsCourses_SportsCourseId",
                        column: x => x.SportsCourseId,
                        principalTable: "SportsCourses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "M88Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    AthleticFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ExpireDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeenCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    M5LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M88Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M88Contracts_AthleticFacilities_AthleticFacilityId",
                        column: x => x.AthleticFacilityId,
                        principalTable: "AthleticFacilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M88Contracts_M5Licenses_M5LicenseId",
                        column: x => x.M5LicenseId,
                        principalTable: "M5Licenses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ChampionshipMedals",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Gold", "طلا" },
                    { 2, "Silver", "نقره" },
                    { 3, "Bronze", "برنز" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Astara", "آستارا" },
                    { 2, "Astaneh", "آستانه اشرفیه" },
                    { 3, "Amlash", "املش" },
                    { 4, "Anzali", "بندر انزلی" },
                    { 5, "Khomam", "خمام" },
                    { 6, "Rasht", "رشت" },
                    { 7, "Rezvanshahr", "رضوانشهر" },
                    { 8, "Roudbar", "رودبار" },
                    { 9, "Roudsar", "رودسر" },
                    { 10, "Siahkal", "سیاهکل" },
                    { 11, "Shaft", "شفت" },
                    { 12, "Somehsara", "صومعه سرا" },
                    { 13, "Tavalesh", "طوالش" },
                    { 14, "Fouman", "فومن" },
                    { 15, "Lahijan", "لاهیجان" },
                    { 16, "Langaroud", "لنگرود" },
                    { 17, "Masal", "ماسال" }
                });

            migrationBuilder.InsertData(
                table: "FacilityGeoTypes",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "City", "شهری" },
                    { 2, "Village", "روستایی" }
                });

            migrationBuilder.InsertData(
                table: "FacilityOwnerships",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Governmental-MSY", "دولتی - وزارت ورزش و جوانان" },
                    { 2, "Governmental-Others", "دولتی - سایر ارگان ها" },
                    { 3, "People-Owned", "باشگاه های خصوصی" }
                });

            migrationBuilder.InsertData(
                table: "FacilityStatuses",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Active", "فعال" },
                    { 2, "Inactive", "غیرفعال" }
                });

            migrationBuilder.InsertData(
                table: "FacilityTypes",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Hall", "سرپوشیده" },
                    { 2, "Land", "روباز" }
                });

            migrationBuilder.InsertData(
                table: "FacilityUsersGenders",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Men", "آقایان" },
                    { 2, "Women", "بانوان" },
                    { 3, "Mix", "مشترک" }
                });

            migrationBuilder.InsertData(
                table: "Federations",
                columns: new[] { "Id", "Address", "CityId", "Name", "NationalId", "PersianName" },
                values: new object[,]
                {
                    { new Guid("048d3536-3171-4944-a497-e7f23caf7e6f"), null, null, "دوچرخه سواری", null, "دوچرخه سواری" },
                    { new Guid("057e4da6-250d-4253-b3ad-19136b782fbb"), null, null, "فوتبال", null, "فوتبال" },
                    { new Guid("058c8900-e8ae-4d7d-a564-92c01b52011d"), null, null, "هندبال", null, "هندبال" },
                    { new Guid("0b798ab0-e4e2-4bc5-92d9-eab2c2ce65f1"), null, null, "بدنسازی و پرورش اندام", null, "بدنسازی و پرورش اندام" },
                    { new Guid("0eab85a4-3b52-41d5-b561-6d0e90c66ee1"), null, null, "ورزش های دانشگاهی", null, "ورزش های دانشگاهی" },
                    { new Guid("12691542-5c57-4f96-bb76-6f34c151663f"), null, null, "ورزش باستانی و پهلوانی", null, "ورزش باستانی و پهلوانی" },
                    { new Guid("18f096e9-2885-4f88-8cee-2eb3cc5598fa"), null, null, "کاراته", null, "کاراته" },
                    { new Guid("1fc8442a-107d-4b2e-a75f-5661348ccd44"), null, null, "ورزش روستائی و بازی های بومی", null, "ورزش روستائی و بازی های بومی" },
                    { new Guid("21e1c089-6443-4fe4-b378-4af0af94ab0d"), null, null, "گلف", null, "گلف" },
                    { new Guid("26fe3e3a-7d19-4882-9f0c-3d8ba707e000"), null, null, "تنیس روی میز", null, "تنیس روی میز" },
                    { new Guid("2df59e1e-31f3-43ab-a728-ce8b1f15a7a7"), null, null, "قایقرانی", null, "قایقرانی" },
                    { new Guid("312e4b6d-e5a0-431b-a832-01fb038053ee"), null, null, "بولینگ، بیلیارد و بولس", null, "بولینگ، بیلیارد و بولس" },
                    { new Guid("31e4e8f8-701d-45ca-a4a6-80c3959ddd0f"), null, null, "شنا، شیرجه و واترپلو", null, "شنا، شیرجه و واترپلو" },
                    { new Guid("3245e223-1c14-4471-ae91-1ca18c6bf097"), null, null, "ورزش های ناشنوایان و کم شنوایان", null, "ورزش های ناشنوایان و کم شنوایان" },
                    { new Guid("3755fb94-8003-4afd-99b6-917f0fc58a16"), null, null, "اتومبیلرانی و موتورسواری", null, "اتومبیلرانی و موتورسواری" },
                    { new Guid("3ea035d1-35a8-4785-a111-4929978be07a"), null, null, "بوکس", null, "بوکس" },
                    { new Guid("40f23c1f-8eda-46ed-aaa6-0e9ec3221e6d"), null, null, "اسکیت", null, "اسکیت" },
                    { new Guid("42b5b710-dc6d-428a-a406-7917c6364f4f"), null, null, "تیراندازی با کمان", null, "تیراندازی با کمان" },
                    { new Guid("569ab01b-69bc-4080-86d3-9dbb27c26c0a"), null, null, "چوگان", null, "چوگان" },
                    { new Guid("577aec5e-22f8-4853-9573-a80df8e67374"), null, null, "وزنه برداری", null, "وزنه برداری" },
                    { new Guid("58a1cd60-3f0c-41f9-84fc-dd0b82042a7a"), null, null, "ورزش های دانش‌آموزی", null, "ورزش های دانش‌آموزی" },
                    { new Guid("5a7561aa-1ef2-472e-b43a-f9da1d738289"), null, null, "ووشو", null, "ووشو" },
                    { new Guid("5c2b623c-0eed-4dba-aef6-3b0f66a777f7"), null, null, "ورزش های جانبازان و توانیابان", null, "ورزش های جانبازان و توانیابان" },
                    { new Guid("677882fa-10c1-4025-8c3a-461c363cdb23"), null, null, "ژیمناستیک", null, "ژیمناستیک" },
                    { new Guid("6ba4793b-887e-460a-b4b8-5c916153ca19"), null, null, "ورزش های کارگری", null, "ورزش های کارگری" },
                    { new Guid("77524e80-2f49-47bd-aa00-595055110f9e"), null, null, "اسکواش", null, "اسکواش" },
                    { new Guid("7a60ede1-80e8-43ba-b72d-3d2ee9fad950"), null, null, "کشتی", null, "کشتی" },
                    { new Guid("7b8e0ea4-0833-452d-9a14-fb80ccbac5e1"), null, null, "پزشکی ورزشی", null, "پزشکی ورزشی" },
                    { new Guid("7d61ed83-5eff-4de3-bc76-6a44e3426a9a"), null, null, "نجات غریق و غواصی", null, "نجات غریق و غواصی" },
                    { new Guid("814a58c4-0f08-491a-a9c7-e310efc97cce"), null, null, "انجمن های ورزش های رزمی", null, "انجمن های ورزش های رزمی" },
                    { new Guid("81cd2f07-f33f-45fb-bc4f-40a1da7f11e5"), null, null, "ورزش های همگانی", null, "ورزش های همگانی" },
                    { new Guid("8986197f-c1d6-4f7a-9c70-d88404eed9e2"), null, null, "کوهنوردی و صعود ورزشی", null, "کوهنوردی و صعود ورزشی" },
                    { new Guid("8a82228b-80d6-4f0d-8b50-17518d94920b"), null, null, "کونگ فو و هنرهای رزمی", null, "کونگ فو و هنرهای رزمی" },
                    { new Guid("aa669454-1f8c-47a8-92ca-d848e84b5ddb"), null, null, "بدمینتون", null, "بدمینتون" },
                    { new Guid("aaee973d-149d-4a17-94fe-9e4b2a220688"), null, null, "انجمن‌های ورزشی", null, "انجمن‌های ورزشی" },
                    { new Guid("b1c1def3-9c80-489e-a7c6-8a29611e2f81"), null, null, "اسکی", null, "اسکی" },
                    { new Guid("b8de8339-0bab-44c2-a8ae-c60ca8596c75"), null, null, "تکواندو", null, "تکواندو" },
                    { new Guid("bad06b4a-3c66-408f-8d17-cdff795c7c45"), null, null, "والیبال", null, "والیبال" },
                    { new Guid("bdaa867f-d16c-46d7-9441-3037aac689e1"), null, null, "کبدی", null, "کبدی" },
                    { new Guid("c401c78e-940d-4d31-9f5a-ceed9dce4ba2"), null, null, "تیراندازی", null, "تیراندازی" },
                    { new Guid("c91c7cc6-a1d9-49d3-b267-2add49369ce1"), null, null, "هاکی", null, "هاکی" },
                    { new Guid("ce8b739c-4a34-407f-86cd-c364e819981b"), null, null, "ورزش های نابینایان و کم بینایان", null, "ورزش های نابینایان و کم بینایان" },
                    { new Guid("d636844c-f497-4866-9dff-af4210687408"), null, null, "دو و میدانی", null, "دو و میدانی" },
                    { new Guid("dcbe9968-46ef-4a18-b693-b91e23045087"), null, null, "ورزش های بیماریهای خاص", null, "ورزش های بیماریهای خاص" },
                    { new Guid("ddf045dc-828a-4ceb-ba7c-ae6b65b48f15"), null, null, "سه گانه", null, "سه گانه" },
                    { new Guid("e7e84d61-787f-4807-aa55-db5ee52a238f"), null, null, "سوارکاری", null, "سوارکاری" },
                    { new Guid("e7fa8c00-ab13-44ff-8ae0-7b5fffb6a2d4"), null, null, "تنیس", null, "تنیس" },
                    { new Guid("eb58bae5-9f93-40ea-9b1a-7be70fd220f4"), null, null, "جودو", null, "جودو" },
                    { new Guid("f4c8278b-4528-483b-87f0-5324702ef56a"), null, null, "بسکتبال", null, "بسکتبال" },
                    { new Guid("f821fe9c-a654-4f7e-919c-676d7d600f90"), null, null, "شمشیربازی", null, "شمشیربازی" },
                    { new Guid("faa91a6e-c43a-4aff-9f38-435e1872c484"), null, null, "شطرنج", null, "شطرنج" },
                    { new Guid("facdc12d-3f16-4109-b29c-7fcb4271a4a4"), null, null, "آمادگی جسمانی", null, "آمادگی جسمانی" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Male", "آقایان" },
                    { 2, "Female", "بانوان" }
                });

            migrationBuilder.InsertData(
                table: "M5BuildingOwnerships",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Owned", "تملیکی" },
                    { 2, "Rented", "استیجاری" }
                });

            migrationBuilder.InsertData(
                table: "M5LicenseStatuses",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Active", "فعال" },
                    { 2, "Expired", "منقضی" }
                });

            migrationBuilder.InsertData(
                table: "M5LicenseTypes",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Personal", "حقیقی" },
                    { 2, "Company", "حقوقی" }
                });

            migrationBuilder.InsertData(
                table: "SportsCourseGrades",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "A", "درجه یک" },
                    { 2, "b", "درجه دو" },
                    { 3, "C", "درجه سه" }
                });

            migrationBuilder.InsertData(
                table: "SportsCourseTypes",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "Coaching", "مربیگری" },
                    { 2, "Referee", "داوری" }
                });

            migrationBuilder.InsertData(
                table: "TournamentAgeGroups",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "1", "نونهالان" },
                    { 2, "2", "خردسالان" },
                    { 3, "3", "زیر 14 سال" },
                    { 4, "4", "نوجوانان" },
                    { 5, "5", "زیر 23 سال" },
                    { 6, "6", "جوانان" },
                    { 7, "7", "بزرگسالان" },
                    { 8, "8", "پیشکسوتان" }
                });

            migrationBuilder.InsertData(
                table: "TournamentLevels",
                columns: new[] { "Id", "Name", "PersianName" },
                values: new object[,]
                {
                    { 1, "1", "بین المللی" },
                    { 2, "2", "آسیایی" },
                    { 3, "3", "جهانی" },
                    { 4, "4", "المپیک" },
                    { 5, "5", "المپیک دانشجویان" },
                    { 6, "6", "اوراسیا" },
                    { 7, "7", "کشورهای اسلامی" },
                    { 8, "8", "بازی های آسیایی" },
                    { 9, "9", "ملی" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_CityId",
                table: "AthleticFacilities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_GeoTypeId",
                table: "AthleticFacilities",
                column: "GeoTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_OwnershipId",
                table: "AthleticFacilities",
                column: "OwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_StatusId",
                table: "AthleticFacilities",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_TypeId",
                table: "AthleticFacilities",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AthleticFacilities_UsersGenderId",
                table: "AthleticFacilities",
                column: "UsersGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_CityId",
                table: "Champions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_GenderId",
                table: "Champions",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_AgeGroupId",
                table: "Championships",
                column: "AgeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_ChampionId",
                table: "Championships",
                column: "ChampionId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_FederationId",
                table: "Championships",
                column: "FederationId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_LevelId",
                table: "Championships",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Championships_MedalId",
                table: "Championships",
                column: "MedalId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseParticipants_SportsCourseId",
                table: "CourseParticipants",
                column: "SportsCourseId");

            migrationBuilder.CreateIndex(
                name: "IX_FederationPresidents_FederationId",
                table: "FederationPresidents",
                column: "FederationId");

            migrationBuilder.CreateIndex(
                name: "IX_Federations_CityId",
                table: "Federations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_M5Licenses_AthleticFicilityId",
                table: "M5Licenses",
                column: "AthleticFicilityId");

            migrationBuilder.CreateIndex(
                name: "IX_M5Licenses_OwnershipId",
                table: "M5Licenses",
                column: "OwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_M5Licenses_StatusId",
                table: "M5Licenses",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_M5Licenses_TypeId",
                table: "M5Licenses",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_M88Contracts_AthleticFacilityId",
                table: "M88Contracts",
                column: "AthleticFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_M88Contracts_M5LicenseId",
                table: "M88Contracts",
                column: "M5LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsCourses_FederationId",
                table: "SportsCourses",
                column: "FederationId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsCourses_GenderId",
                table: "SportsCourses",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsCourses_GradeId",
                table: "SportsCourses",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_SportsCourses_TypeId",
                table: "SportsCourses",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Championships");

            migrationBuilder.DropTable(
                name: "CourseParticipants");

            migrationBuilder.DropTable(
                name: "FederationPresidents");

            migrationBuilder.DropTable(
                name: "M88Contracts");

            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "ChampionshipMedals");

            migrationBuilder.DropTable(
                name: "TournamentAgeGroups");

            migrationBuilder.DropTable(
                name: "TournamentLevels");

            migrationBuilder.DropTable(
                name: "SportsCourses");

            migrationBuilder.DropTable(
                name: "M5Licenses");

            migrationBuilder.DropTable(
                name: "Federations");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "SportsCourseGrades");

            migrationBuilder.DropTable(
                name: "SportsCourseTypes");

            migrationBuilder.DropTable(
                name: "AthleticFacilities");

            migrationBuilder.DropTable(
                name: "M5BuildingOwnerships");

            migrationBuilder.DropTable(
                name: "M5LicenseStatuses");

            migrationBuilder.DropTable(
                name: "M5LicenseTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "FacilityGeoTypes");

            migrationBuilder.DropTable(
                name: "FacilityOwnerships");

            migrationBuilder.DropTable(
                name: "FacilityStatuses");

            migrationBuilder.DropTable(
                name: "FacilityTypes");

            migrationBuilder.DropTable(
                name: "FacilityUsersGenders");
        }
    }
}
