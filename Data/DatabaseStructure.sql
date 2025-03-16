﻿create database [Reporter]
	collate Persian_100_CI_AI;

use [Reporter];

-- Basic Tables ------------------------------------------------------------------------------------
drop table if exists [AgeGroups];
create table [AgeGroups] (
	[Id] int identity(1,1) not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_AgeGroups] primary key ([Id]),
	constraint [IX_AgeGroups_Name] unique ([NormalizedName])
);

insert into [AgeGroups]
	([Name], [PersianName])
	values
	('Under10', 'نونهالان'),
	('Under12', 'خردسالان'),
	('Under14', 'زیر 14 سال'),
	('Under18', 'نوجوانان'),
	('Youth', 'جوانان'),
	('Under23', 'زیر 23 سال'),
	('Adults', 'بزرگسالان'),
	('Veterans', 'پیشکسوتان');



drop table if exists [Cities];
create table [Cities] (
	[Id] int identity(1,1) not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_Cities] primary key ([Id]),
	constraint [IX_Cities_Name] unique ([NormalizedName])
);

insert into [Cities]
	([Name], [PersianName])
	values
	('Astara', 'آستارا'),
	('Astaneh', 'آستانه اشرفیه'),
	('Amlash', 'املش'),
	('Anzali', 'بندر انزلی'),
	('Khomam', 'خمام'),
	('Rasht', 'رشت'),
	('Rezvanshahr', 'رضوانشهر'),
	('Roudbar', 'رودبار'),
	('Roudsar', 'رودسر'),
	('Siahkal', 'سیاهکل'),
	('Shaft', 'شفت'),
	('Somehsara', 'صومعه سرا'),
	('Tavalesh', 'طوالش'),
	('Fouman', 'فومن'),
	('Lahijan', 'لاهیجان'),
	('Langaroud', 'لنگرود'),
	('Masal', 'ماسال');



drop table if exists [EventLevels]
create table [EventLevels] (
	[Id] int identity(1,1) not null,
	[IsInternational] bit not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_EventLevels] primary key ([Id]),
	constraint [IX_EventLevels_Name] unique ([NormalizedName])
);
insert into [EventLevels]
	([IsInternational], [Name], [PersianName])
	values
	(0, 'Province', 'استانی'),
	(0, 'National', 'ملی'),
	(0, 'Para National', 'پارا ملی'),
	(0, 'National Olympiad', 'المپیاد استعدادهای برتر-کشوری'),
	(1, 'International Olympiad', 'المپیاد استعدادهای برتر-فراملی'),
	(1, 'International', 'بین‌ المللی'),
	(1, 'Para International', 'پارا بین‌ المللی'),
	(1, 'Asian', 'آسیایی'),
	(1, 'Para Asian', 'پارا آسیایی'),
	(1, 'Eurasian', 'اوراسیا'),
	(1, 'World', 'جهانی'),
	(1, 'Para World', 'پارا جهانی'),
	(1, 'Asian Games', 'بازی های آسیایی'),
	(1, 'Asian Para Games', 'پارا بازی های آسیایی'),
	(1, 'Islamic Solidarity', 'کشورهای اسلامی'),
	(1, 'Olympic', 'المپیک'),
	(1, 'Paralympic', 'پارا المپیک'),
	(1, 'Winter Olympic', 'المپیک زمستانی'),
	(1, 'Summer Olympic', 'المپیک تابستانی'),
	(1, 'Universiade', 'المپیک دانشجویان'),
	(1, 'International Beach', 'ساحلی بین المللی');



drop table if exists [FacilityTypes];
create table [FacilityTypes] (
	[Id] int identity(1,1) not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_FacilityTypes] primary key ([Id]),
	constraint [IX_FacilityTypes_Name] unique ([NormalizedName])
);

insert into [FacilityTypes]
	([Name], [PersianName])
	values
	('Hall', 'سرپوشیده'),
	('Land', 'روباز'),
	('Complex', 'مجموعه'),
	('Centre', 'دفتر باشگاه');



drop table if exists [Federations];
create table [Federations] (
	[Id] uniqueidentifier default newid() not null,
	[CityId] int null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	[NationalId] nvarchar(max) null,
	[Address] nvarchar(max) null,
	[ZipCode] nvarchar(max) null,
	[Phone] nvarchar(max) null,
	constraint [PK_Federations] primary key ([Id]),
	constraint [IX_Federations_Name] unique ([CityId], [NormalizedName]),
	constraint [FK_Federations_Cities_CityId] foreign key ([CityId]) references [Cities]([Id])
 );



drop table if exists [Genders];
create table [Genders] (
	[Id] int identity(1,1) not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_Genders] primary key ([Id]),
	constraint [IX_Genders_Name] unique ([NormalizedName])
);

insert into [Genders]
	([Name], [PersianName])
	values
	('Male', 'آقا'),
	('Female', 'خانم');



drop table if exists [InviteeRoles];
create table [InviteeRoles] (
	[Id] int identity(1,1) not null,
	[Role] nvarchar(256) not null,
	[NormalizedRole] as upper([Role]),
	[PersianTitle] nvarchar(max) not null,
	constraint [PK_InviteeRoles] primary key ([Id]),
	constraint [IX_InviteeRoles] unique ([NormalizedRole])
);

insert into [InviteeRoles]
	([Role], [PersianTitle])
	values
	('Player', 'بازیکن'),
	('Coach', 'مربی');



drop table if exists [LegalTitles];
create table [LegalTitles] (
	[Id] int identity(1,1) not null,
	[Name] nvarchar(256) not null,
	[NormalizedName] as upper([Name]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_LegalTitles] primary key ([Id]),
	constraint [IX_LegalTitles_Name] unique ([NormalizedName])
);

insert into [LegalTitles]
	([Name], [PersianName])
	values
	('Beneficial', 'حقیقی'),
	('Legal', 'حقوقی');



drop table if exists [Medals];
create table [Medals] (
	[Id] int identity(1,1) not null,
	[IsIndividualMedal] bit not null,
	[Color] nvarchar(256) not null,
	[NormalizedColor] as upper([Color]),
	[PersianTitle] nvarchar(256) not null,
	constraint [PK_Medals] primary key ([Id]),
	constraint [IX_Medals_Medal] unique ([IsIndividualMedal], [NormalizedColor])
);

insert into [Medals]
	([IsIndividualMedal], [Color], [PersianTitle])
	values
	(1, 'Gold', 'طلا'),
	(1, 'Silver', 'نقره'),
	(1, 'Bronze', 'برنز'),
	(0, 'Gold', 'طلا تیمی'),
	(0, 'Silver', 'نقره تیمی'),
	(0, 'Bronze', 'برنز تیمی');



drop table if exists [MeetingTypes];
create table [MeetingTypes] (
	[Id] int identity(1,1) not null,
	[Type] nvarchar(256) not null,
	[NormalizedType] as upper([Type]),
	[PersianTitle] nvarchar(256) not null,
	[IsElective] bit not null,
	constraint [PK_MeetingTypes] primary key ([Id]),
	constraint [IX_MeetingTypes_Type] unique ([NormalizedType])
);

insert into [MeetingTypes]
	([Type], [PersianTitle], [IsElective])
	values
	('General', 'جلسه عمومی سالیانه', 0),
	('Elective', 'انتخابات', 1),
	('ExtraOrdinary', 'جلسه فوق العاده', 1);



drop table if exists [Ownerships]
create table [Ownerships] (
	[Id] int identity(1,1) not null,
	[IsGovernmentOwned] bit not null,
	[Type] nvarchar(256) not null,
	[NormalizedType] as upper([Type]),
	[PersianTitle] nvarchar(256) not null,
	constraint [PK_Ownerships] primary key ([Id]),
	constraint [IX_Ownerships_Type] unique ([IsGovernmentOwned], [NormalizedType])
);

insert into [Ownerships]
	([IsGovernmentOwned], [Type], [PersianTitle])
	values
	(1, 'MSYOwned', 'دولتی - وزارت ورزش و جوانان'),
	(1, 'GovernmentOther', 'دولتی - سایر ارگان ها'),
	(0, 'PrivateIndividual', 'باشگاه خصوصی - حقیقی'),
	(0, 'PrivateCorporate', 'باشگاه خصوصی - حقوقی');



drop table if exists [SportsCourseGrades];
create table [SportsCourseGrades] (
	[Id] int identity(1,1) not null,
	[Grade] nvarchar(256) not null,
	[NormalizedGrade] as upper([Grade]),
	[PersianName] nvarchar(256) not null,
	constraint [PK_SportsCourseGrades] primary key ([Id]),
	constraint [IX_SportsCourseGrades_Grade] unique ([NormalizedGrade])
);

insert into [SportsCourseGrades]
	([Grade], [PersianName])
	values
	('C', 'درجه سه'),
	('B', 'درجه دو'),
	('A', 'درجه یک'),
	('National', 'ملی'),
	('International-C', 'درجه سه بین المللی'),
	('International-B', 'درجه دو بین المللی'),
	('International-A', 'درجه یک بین المللی'),
	('Asia-D', 'D آسیا'),
	('Asia-C', 'C آسیا');



-- Main Tables -------------------------------------------------------------------------------------
drop table if exists [FederationPresidents];
create table [FederationPresidents] (
	[Id] uniqueidentifier default newid() not null,
	[FederationId] uniqueidentifier not null,
	[Name] nvarchar(max) not null,
	[SeedCode] nvarchar(max) not null,
	[BirthDate] nvarchar(max) not null,
	[Phone] nvarchar(max) null,
	[EducationalQualification] nvarchar(max) null,
	[EducationalMajor] nvarchar(max) null,
	[AppointmentOrder] nvarchar(max) null,
	[AppointmentDate] nvarchar(max) null,
	[IsPresident] bit not null,
	constraint [PK_FederationPresidents] primary key ([Id]),
	constraint [FK_FederationPresidents_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]) 
);

drop table if exists [FederationMeetings];
create table [FederationMeetings] (
	[Id] uniqueidentifier default newid() not null,
	[FederationId] uniqueidentifier not null,
	[TypeId] int not null,
	[Year] int not null,
	[Month] int not null,
	[Day] int not null,
	[AttendeesCount] int not null,
	constraint [PK_FederationMeetings] primary key ([Id]),
	constraint [IX_FederationMeetings] unique ([FederationId], [TypeId], [Year], [Month], [Day]),
	constraint [FK_FederationMeetings_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
	constraint [FK_FederationMeetings_MeetingTypes_TypeId] foreign key ([TypeId]) references [MeetingTypes]([Id])
);

drop table if exists [MeetingVotes];
create table [MeetingVotes] (
	[MeetingId] uniqueidentifier not null,
	[Name] nvarchar(256) not null,
	[VotesCount] int not null,
	constraint [PK_MeetingVotes] primary key ([MeetingId], [Name]),
	constraint [FK_MeetingVotes_FederationMeetings_MeetingId] foreign key ([MeetingId]) references [FederationMeetings]([Id])
);



drop table if exists [AthleticFacilities];
create table [AthleticFacilities] (
	[Id] uniqueidentifier default newid() not null,
	[Name] nvarchar(max) not null,
	[OwnershipId] int not null,
	[TypeId] int null,
	[IsRural] bit null,
	[CityId] int not null,
	[District] nvarchar(max) null,
	[Area] int null,
	[IsActive] bit default 1 not null,
	[Sports] nvarchar(max) null,
	[ZipCode] nvarchar(max) null,
	[Address] nvarchar(max) null,
	[Phone] nvarchar(max) null,
	constraint [PK_AthleticFacilities] primary key ([Id]),
	constraint [FK_AthleticFacilities_Ownerships_OwnershipId] foreign key ([OwnershipId]) references [Ownerships]([Id]),
	constraint [FK_AthleticFacilities_FacilityTypes_TypeId] foreign key ([TypeId]) references [FacilityTypes]([Id]),
	constraint [FK_AthleticFacilities_Cities_CityId] foreign key ([CityId]) references [Cities]([Id])
);

drop table if exists [FacilityUserGenders];
create table [FacilityUserGeneders] (
	[FacilityId] uniqueidentifier not null,
	[GenderId] int not null,
	constraint [PK_FacilityUserGenders] primary key ([FacilityId], [GenderId]),
	constraint [FK_FacilityUserGenders_AthleticFacilities_FacilityId] foreign key ([FacilityId]) references [AthleticFacilities]([Id]),
	constraint [FK_FacilityUserGenders_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
);



drop table if exists [M5Licenses];
create table [M5Licenses] (
	[Id] uniqueidentifier default newid() not null,
	[FacilityId] uniqueidentifier not null,
	[LegalTitleId] int null,
	[IsOwner] bit null,
	[Serial] nvarchar(256) null,
	[StartDate] date null,
	[ExpireDate] date null,
	[Company] nvarchar(max) null,
	[Name] nvarchar(max) not null,
	[SeenCode] nvarchar(max) null,
	[Phone] nvarchar(max) null,
	constraint [PK_M5Licenses] primary key ([Id]),
	constraint [FK_M5Licenses_AthleticFacilities_FacilityId] foreign key ([FacilityId]) references [AthleticFacilities]([Id]),
	constraint [FK_M5Licenses_LegalTitles_LegalTitleId] foreign key ([LegalTitleId]) references [LegalTitles]([Id]),
	constraint [IX_M5Licenses_Serial] unique ([Serial])
);



drop table if exists [M88Contracts]
create table [M88Contracts] (
	[Id] uniqueidentifier default newid() not null,
	[FacilityId] uniqueidentifier not null,
	[Serial] nvarchar(256) not null,
	[StartDate] date not null,
	[ExpireDate] date not null,
	[Name] nvarchar(max) not null,
	[SeenCode] nvarchar(max) not null,
	[Phone] nvarchar(max) not null,
	[M5LicenseId] uniqueidentifier null,
	constraint [PK_M88Contracts] primary key ([Id]),
	constraint [FK_M88Contracts_AthleticFacilities_FacilityId] foreign key ([FacilityId]) references [AthleticFacilities]([Id]),
	constraint [FK_M88Contracts_M5Licenses_M5LicenseId] foreign key ([M5LicenseId]) references [M5Licenses]([Id]),
	constraint [IX_M88Contracts_Serial] unique ([Serial])
);



drop table if exists [Champions];
create table [Champions] (
	[Id] uniqueidentifier default newid() not null,
	[Name] nvarchar(max) not null,
	[SeenCode] nvarchar(10) null,
	[Phone] nvarchar(max) null,
	[GenderId] int not null,
	[CityId] int null,
	constraint [PK_Champions] primary key ([Id]),
	constraint [FK_Champions_SeenCode] unique ([SeenCode]),
	constraint [FK_Champions_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id]),
	constraint [FK_Champions_Cities_City_Id] foreign key ([CityId]) references [Cities]([Id])
);

drop table if exists [Championships];
create table [Championships] (
	[Id] uniqueidentifier default newid() not null,
	[FederationId] uniqueidentifier not null,
	[Sport] nvarchar(max) not null,
	[AgeGroupId] int null,
	[EventLevelId] int not null,
	[Host] nvarchar(max) not null,
	[Year] nvarchar(max) not null,
	[MedalId] int not null,
	constraint [PK_Championships] primary key ([Id]),
	constraint [FK_Championships_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
	constraint [FK_Championships_AgeGroups_AgeGroupsId] foreign key ([AgeGroupId]) references [AgeGroups]([Id]),
	constraint [FK_Championships_EventLevels_EventLevelId] foreign key ([EventLevelId]) references [EventLevels]([Id]),
	constraint [FK_Championships_Medals_MedalId] foreign key ([MedalId]) references [Medals]([Id])
);

drop table if exists [ChampionChampionships];
create table [ChampionChampionships] (
	[ChampionId] uniqueidentifier not null,
	[ChampionshipId] uniqueidentifier not null,
	constraint [PK_ChampionChampionships] primary key ([ChampionId], [ChampionshipId]),
	constraint [FK_ChampionChampionships_Champions_ChampionId] foreign key ([ChampionId]) references [Champions]([Id]),
	constraint [FK_ChampionChampionships_Championship_ChampionshipId] foreign key ([ChampionshipId]) references [Championships]([Id])
);



drop table if exists [SportsCourses];
create table [SportsCourses] (
	[Id] uniqueidentifier default newid() not null,
	[IsCoaching] bit not null,
	[GradeId] int not null,
	[FederationId] uniqueidentifier not null,
	[Year] nvarchar(max) not null,
	constraint [PK_SportsCourses] primary key ([Id]),
	constraint [FK_SportsCourses_SportsCourseGrades_GradeId] foreign key ([GradeId]) references [SportsCourseGrades]([Id]),
	constraint [FK_SportsCourses_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id])
);

drop table if exists [SportsCourseParticipants];
create table [SportsCourseParticipants] (
	[Id] uniqueidentifier default newid() not null,
	[Name] nvarchar(max) not null,
	[SeenCode] nvarchar(10) null,
	[Phone] nvarchar(max) null,
	[GenderId] int not null,
	constraint [PK_SportsCourseParticipants] primary key ([Id]),
	constraint [IX_SportsCourseParticipants_SeenCode] unique ([SeenCode]),
	constraint [FK_SportsCourseParticipants_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
);

drop table if exists [SportsCourseCourseParticipants];
create table [SportsCourseCourseParticipants] (
	[CourseId] uniqueidentifier not null,
	[ParticipantId] uniqueidentifier not null,
	constraint [PK_SportsCourseCourseParticipants] primary key ([CourseId], [ParticipantId]),
	constraint [FK_SportsCourseCourseParticipants_SportsCourses_CourseId] foreign key ([CourseId]) references [SportsCourses]([Id]),
	constraint [FK_SportsCourseCourseParticipants_SportsCourseParticipants_ParticipantsId] foreign key ([ParticipantId]) references [SportsCourseParticipants]([Id])
);



drop table if exists [Insurances];
create table [Insurances] (
	[Id] uniqueidentifier default newid() not null,
	[CityId] int not null,
	[FederationId] uniqueidentifier not null,
	[GenderId] int not null,
	[Year] int not null,
	[Month] int not null,
	[Count] int not null,
	constraint [PK_Insurances] primary key ([Id]),
	constraint [IX_Insurances] unique ([CityId], [FederationId], [GenderId], [Year], [Month]),
	constraint [FK_Insurances_Cities_CityId] foreign key ([CityId]) references [Cities]([Id]),
	constraint [FK_Insurances_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
	constraint [FK_Insurances_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
);



drop table if exists [Records];
create table [Records] (
	[Id] uniqueidentifier default newid() not null,
	[FederationId] uniqueidentifier not null,
	[Sport] nvarchar(max) not null,
	[AgeGroupId] int null,
	[OldRecord] nvarchar(max) not null,
	[Name] nvarchar(max) not null,
	[Date] date not null,
	[CityId] int not null,
	[Location] nvarchar(max) null,
	[Current] nvarchar(max) not null,
	constraint [PK_Records] primary key ([Id]),
	constraint [FK_Records_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
	constraint [FK_Records_AgeGroups_AgeGroupId] foreign key ([AgeGroupId]) references [AgeGroups]([Id]),
	constraint [FK_Records_Cities_CityId] foreign key ([CityId]) references [Cities]([Id])
);




drop table if exists [NationalTeamInvitees];
create table [NationalTeamInvitees] (
	[Id] uniqueidentifier default newid() not null,
	[RoleId] int not null,
	[Name] nvarchar(256) not null,
	[GenderId] int not null,
	[FederationId] uniqueidentifier not null,
	[AgeGroupId] int null,
	[Year] int not null,
	[IsAccepted] bit not null, -- عضو تیم ملی
	constraint [PK_NationalTeamInvitees] primary key ([Id]),
	constraint [FK_NationalTeamInvitees_InviteeRoles_RoleId] foreign key ([RoleId]) references [InviteeRoles]([Id]),
	constraint [FK_NationalTeamInvitees_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id]),
	constraint [FK_NationalTeamInvitees_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
	constraint [FK_NationalTeamInvitees_AgeGroups_AgeGroupId] foreign key ([AgeGroupId]) references [AgeGroups]([Id])
);



drop table if exists [ConstructionProjects];
create table [ConstructionProjects] (
	[Id] uniqueidentifier default newid() not null,
	[Title] nvarchar(256) not null,
	[CityId] int not null,
	[IsRural] bit null,
	[IsRenovation] bit not null,
	[TypeId] int not null,
	[StartYear] int not null,
	[FinishYear] int null,
	[Area] int not null,
	[SportArea] int not null,
	constraint [PK_ConstructionProjects] primary key ([Id]),
	constraint [FK_ConstructionProjects_Cities_CityId] foreign key ([CityId]) references [Cities]([Id]),
	constraint [FK_ConstructionProjects_FacilityTypes_TypeId] foreign key ([TypeId]) references [FacilityTypes]([Id])
);

drop table if exists [ProjectUserGenders];
create table [ProjectUserGeneders] (
	[ProjectId] uniqueidentifier not null,
	[GenderId] int not null,
	constraint [PK_ProjectUserGenders] primary key ([ProjectId], [GenderId]),
	constraint [FK_ProjectUserGenders_ConstructionProjects_ProjectId] foreign key ([ProjectId]) references [ConstructionProjects]([Id]),
	constraint [FK_ProjectUserGenders_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
);




-- جدول برای پروژه های عمرانی
-- جدول برای تغییر پیشرفت فیزیکی
-- جدول برای ردیف های بودجه تعریف شده در هر سال برای پروژه
