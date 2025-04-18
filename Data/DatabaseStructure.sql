go
if db_id('Reporter') is null
begin
	create database [Reporter]
		collate Persian_100_CI_AI;
	print 'Reporter database created succesfully.';
end
else
begin
	print 'Reporter database already exists.';
end;
go

if db_id('Reporter') is not null
begin
	use [Reporter];
end;

-- General Tables
if not exists (
	select * from sys.objects
		where name = 'Cities' and type = 'U'
)
begin
	create table [Cities] (
		[Id] int identity(0,1) not null,
		[Name] nvarchar(256) not null,
		[NormalizedName] as upper([Name]),
		[PersianName] nvarchar(256) not null,
		constraint [PK_Cities] primary key ([Id]),
		constraint [IX_Cities_Name] unique ([NormalizedName])
	);

	insert into [Cities]
		([Name], [PersianName])
		values
		('Guilan', 'استان'),
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
end;

if not exists (
	select * from sys.objects
		where name = 'Genders' and type = 'U'
)
begin
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
end;

-- Federations Tables
if not exists (
	select * from sys.objects
		where name = 'Federations' and type = 'U'
)
begin
	create table [Federations] (
		[Id] int identity(1,1) not null,
		[Name] nvarchar(256) not null,
		[NormalizedName] as upper([Name]),
		[PersianName] nvarchar(256) not null,
		constraint [PK_Federations] primary key ([Id]),
		constraint [IX_Federations_Name] unique ([NormalizedName])
	 );
end;

if not exists (
	select * from sys.objects
		where name = 'CityFederations' and type = 'U'
)
begin
	create table [CityFederations] (
		[FederationId] int not null,
		[CityId] int not null,
		[NationalId] nvarchar(16) null,
		[Address] nvarchar(max) null,
		[ZipCode] nvarchar(max) null,
		[Phone] nvarchar(max) null,
		constraint [PK_CityFederations] primary key ([FederationId], [CityId]),
		constraint [FK_CityFederations_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
		constraint [FK_CityFederations_Cities_CityId] foreign key ([CityId]) references [Cities]([Id])
	 );

	 create unique index [IX_CityFederations_NationalId] 
		on [CityFederations]([NationalId]) 
			where [NationalId] is not null;
end;

if not exists (
	select * from sys.objects
		where name = 'FederationPresidents' and type = 'U'
)
begin
	create table [FederationPresidents] (
		[Id] uniqueidentifier default newid() not null,
		[FederationId] int not null,
		[CityId] int not null,
		[Name] nvarchar(max) not null,
		[SeenCode] nvarchar(max) not null,
		[BirthDate] nvarchar(max) not null,
		[Phone] nvarchar(max) null,
		[EducationalQualification] nvarchar(max) null,
		[EducationalMajor] nvarchar(max) null,
		[AppointmentOrder] nvarchar(max) null,
		[AppointmentDate] nvarchar(max) null,
		[TermEnd] nvarchar(max) null,
		[IsPresident] bit not null,
		constraint [PK_FederationPresidents] primary key ([Id]),
		constraint [FK_FederationPresidents_CityFederations_CityFederationId] foreign key ([FederationId], [CityId]) references [CityFederations]([FederationId], [CityId]) 
	);
end;

if not exists (
	select * from sys.objects
		where name = 'MeetingTypes' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'FederationMeetings' and type = 'U'
)
begin
	create table [FederationMeetings] (
		[Id] uniqueidentifier default newid() not null,
		[FederationId] int not null,
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
end;

if not exists (
	select * from sys.objects
		where name = 'MeetingVotes' and type = 'U'
)
begin
	create table [MeetingVotes] (
		[MeetingId] uniqueidentifier not null,
		[Name] nvarchar(256) not null,
		[VotesCount] int not null,
		constraint [PK_MeetingVotes] primary key ([MeetingId], [Name]),
		constraint [FK_MeetingVotes_FederationMeetings_MeetingId] foreign key ([MeetingId]) references [FederationMeetings]([Id])
	);
end;

-- Facilities Tables
if not exists (
	select * from sys.objects
		where name = 'Ownerships' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'FacilityTypes' and type = 'U'
)
begin
	create table [FacilityTypes] (
		[Id] int identity(1,1) not null,
		[Type] nvarchar(256) not null,
		[NormalizedType] as upper([Type]),
		[PersianTitle] nvarchar(256) not null,
		constraint [PK_FacilityTypes] primary key ([Id]),
		constraint [IX_FacilityTypes_Type] unique ([NormalizedType])
	);

	insert into [FacilityTypes]
		([Type], [PersianTitle])
		values
		('Hall', 'سرپوشیده'),
		('Land', 'روباز'),
		('Complex', 'مجموعه'),
		('Centre', 'دفتر باشگاه');
end;

if not exists (
	select * from sys.objects
		where name = 'AthleticFacilities' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'FacilityUserGeneders' and type = 'U'
)
begin
	create table [FacilityUserGeneders] (
		[FacilityId] uniqueidentifier not null,
		[GenderId] int not null,
		constraint [PK_FacilityUserGenders] primary key ([FacilityId], [GenderId]),
		constraint [FK_FacilityUserGenders_AthleticFacilities_FacilityId] foreign key ([FacilityId]) references [AthleticFacilities]([Id]),
		constraint [FK_FacilityUserGenders_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'LegalTitles' and type = 'U'
)
begin
	create table [LegalTitles] (
		[Id] int identity(1,1) not null,
		[Title] nvarchar(256) not null,
		[NormalizedTitle] as upper([Title]),
		[PersianTitle] nvarchar(256) not null,
		constraint [PK_LegalTitles] primary key ([Id]),
		constraint [IX_LegalTitles_Title] unique ([NormalizedTitle])
	);

	insert into [LegalTitles]
		([Title], [PersianTitle])
		values
		('Beneficial', 'حقیقی'),
		('Legal', 'حقوقی');
end;

if not exists (
	select * from sys.objects
		where name = 'M5Licenses' and type = 'U'
)
begin
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
		constraint [FK_M5Licenses_LegalTitles_LegalTitleId] foreign key ([LegalTitleId]) references [LegalTitles]([Id])
	);

	create unique index [IX_M5Licenses_Serial] 
		on [M5Licenses]([Serial])
			where [Serial] is not null;
end;

if not exists (
	select * from sys.objects
		where name = 'M88Contracts' and type = 'U'
)
begin
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
		constraint [FK_M88Contracts_M5Licenses_M5LicenseId] foreign key ([M5LicenseId]) references [M5Licenses]([Id])
	);

	create unique index [IX_M88Contracts_Serial]
		on [M88Contracts]([Serial])
			where [Serial] is not null;
end;

-- Registered Athletes Tables
if not exists (
	select * from sys.objects
		where name = 'Insurances' and type = 'U'
)
begin
	create table [Insurances] (
		[Id] uniqueidentifier default newid() not null,
		[CityId] int not null,
		[FederationId] int not null,
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
end;

-- Sports Courses Tables
if not exists (
	select * from sys.objects
		where name = 'SportsCourseGrades' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'SportsCourses' and type = 'U'
)
begin
	create table [SportsCourses] (
		[Id] uniqueidentifier default newid() not null,
		[IsCoaching] bit not null,
		[GradeId] int not null,
		[FederationId] int not null,
		[Year] nvarchar(max) not null,
		constraint [PK_SportsCourses] primary key ([Id]),
		constraint [FK_SportsCourses_SportsCourseGrades_GradeId] foreign key ([GradeId]) references [SportsCourseGrades]([Id]),
		constraint [FK_SportsCourses_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'SportsCourseParticipants' and type = 'U'
)
begin
	create table [SportsCourseParticipants] (
		[Id] uniqueidentifier default newid() not null,
		[Name] nvarchar(max) not null,
		[SeenCode] nvarchar(10) null,
		[Phone] nvarchar(max) null,
		[GenderId] int not null,
		constraint [PK_SportsCourseParticipants] primary key ([Id]),
		constraint [FK_SportsCourseParticipants_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
	);

	create unique index [IX_SportsCourseParticipants_SeenCode]
		on [SportsCourseParticipants]([SeenCode])
			where [SeenCode] is not null;
end;

if not exists (
	select * from sys.objects
		where name = 'SportsCourseCourseParticipants' and type = 'U'
)
begin
	create table [SportsCourseCourseParticipants] (
		[CourseId] uniqueidentifier not null,
		[ParticipantId] uniqueidentifier not null,
		constraint [PK_SportsCourseCourseParticipants] primary key ([CourseId], [ParticipantId]),
		constraint [FK_SportsCourseCourseParticipants_SportsCourses_CourseId] foreign key ([CourseId]) references [SportsCourses]([Id]),
		constraint [FK_SportsCourseCourseParticipants_SportsCourseParticipants_ParticipantsId] foreign key ([ParticipantId]) references [SportsCourseParticipants]([Id])
	);
end;

-- Champions Tables
if not exists (
	select * from sys.objects
		where name = 'Athletes' and type = 'U'
)
begin
	create table [Athletes] (
		[Id] uniqueidentifier default newid() not null,
		[Name] nvarchar(256) not null,
		[SeenCode] nvarchar(10) null,
		[GenderId] int not null,
		[CityId] int not null,
		[Phone] nvarchar(max) null,
		constraint [PK_Athletes] primary key ([Id]),
		constraint [FK_Athletes_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id]),
		constraint [FK_Athletes_Cities_CityId] foreign key ([CityId]) references [Cities]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'AgeGroups' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'CampTypes' and type = 'U'
)
begin
	create table [CampTypes] (
		[Id] int identity(1,1) not null,
		[Type] nvarchar(256) not null,
		[NormalizedType] as upper([Type]),
		[PersianType] nvarchar(max) not null,
		constraint [PK_CampTypes] primary key ([Id]),
		constraint [IX_CampTypes] unique ([NormalizedType])
	);

	insert into [CampTypes]
		([Type], [PersianType])
		values
		('Tryout', 'انتخابی'),
		('Training', 'اعزام');
end;

if not exists (
	select * from sys.objects
		where name = 'NationalTeamCamps' and type = 'U'
)
begin
	create table [NationalTeamCamps] (
		[Id] uniqueidentifier default newid() not null,
		[FederationId] int not null,
		[Sport] nvarchar(max) null,
		[GenderId] int not null,
		[AgeGroupId] int null,
		[Year] int not null,
		[TypeId] int not null,
		[Location] nvarchar(max) not null,
		constraint [PK_NationalTeamCamps] primary key ([Id]),
		constraint [FK_NationalTeamCamps_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
		constraint [FK_NationalTeamCamps_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id]),
		constraint [FK_NationalTeamCamps_AgeGroups_AgeGroupId] foreign key ([AgeGroupId]) references [AgeGroups]([Id]),
		constraint [FK_NationalTeamCamps_CampTypes_TypeId] foreign key ([TypeId]) references [CampTypes]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'InviteeRoles' and type = 'U'
)
begin
	create table [InviteeRoles] (
		[Id] int identity(1,1) not null,
		[Role] nvarchar(256) not null,
		[NormalizedRole] as upper([Role]),
		[PersianRole] nvarchar(max) not null,
		constraint [PK_InviteeRoles] primary key ([Id]),
		constraint [IX_InviteeRoles] unique ([NormalizedRole])
	);

	insert into [InviteeRoles]
		([Role], [PersianRole])
		values
		('Player', 'بازیکن'),
		('Coach', 'مربی');
end;

if not exists (
	select * from sys.objects
		where name = 'CampInvitees' and type = 'U'
)
begin
	create table [CampInvitees] (
		[CampId] uniqueidentifier not null,
		[AthleteId] uniqueidentifier not null,
		[RoleId] int not null,
		constraint [PK_CampInvitees] primary key ([CampId], [AthleteId]),
		constraint [FK_CampInvitees_NationalTeamCamps_CampId] foreign key ([CampId]) references [NationalTeamCamps]([Id]),
		constraint [FK_CampInvitees_Athletes_AthleteId] foreign key ([AthleteId]) references [Athletes]([Id]),
		constraint [FK_CampInvitees_InviteeRoles_RoleId] foreign key ([RoleId]) references [InviteeRoles]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'TournamentLevels' and type = 'U'
)
begin
	create table [TournamentLevels] (
		[Id] int identity(1,1) not null,
		[IsInternational] bit not null,
		[Title] nvarchar(256) not null,
		[NormalizedTitle] as upper([Title]),
		[PersianTitle] nvarchar(256) not null,
		constraint [PK_TournamentLevelsLevels] primary key ([Id]),
		constraint [IX_TournamentLevelsLevels_Title] unique ([NormalizedTitle])
	);

	insert into [TournamentLevels]
		([IsInternational], [Title], [PersianTitle])
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
end;

if not exists (
	select * from sys.objects
		where name = 'Tournaments' and type = 'U'
)
begin
	create table [Tournaments] (
		[Id] uniqueidentifier default newid() not null,
		[FederationId] int not null,
		[Sport] nvarchar(max) not null,
		[AgeGroupId] int null,
		[LevelId] int not null,
		[Host] nvarchar(max) not null,
		[Year] int not null,
		[Month] int not null,
		[Day] int null,
		constraint [PK_Tournaments] primary key ([Id]),
		constraint [FK_Tournaments_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
		constraint [FK_Tournaments_AgeGroups_AgeGroupsId] foreign key ([AgeGroupId]) references [AgeGroups]([Id]),
		constraint [FK_Tournaments_TournamentLevels_LevelId] foreign key ([LevelId]) references [TournamentLevels]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'Medals' and type = 'U'
)
begin
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
end;

if not exists (
	select * from sys.objects
		where name = 'Champions' and type = 'U'
)
begin
	create table [Champions] (
		[Id] uniqueidentifier default newid() not null,
		[AthleteId] uniqueidentifier not null,
		[TournamentId] uniqueidentifier not null,
		[Field] nvarchar(256) null,
		[MedalId] int null,
		constraint [PK_Champions] primary key ([Id]),
		constraint [IX_Champions] unique ([AthleteId], [TournamentId], [Field], [MedalId]),
		constraint [FK_Champions_Athletes_AthleteId] foreign key ([AthleteId]) references [Athletes]([Id]),
		constraint [FK_Champions_Tournaments_TournamentId] foreign key ([TournamentId]) references [Tournaments]([Id]),
		constraint [FK_Champions_Medals_MedalId] foreign key ([MedalId]) references [Medals]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'Records' and type = 'U'
)
begin
	create table [Records] (
		[Id] uniqueidentifier default newid() not null,
		[AthleteId] uniqueidentifier not null,
		[FederationId] int not null,
		[Sport] nvarchar(256) not null,
		[AgeGroupId] int null,
		[Date] nvarchar(max) not null,
		[Host] nvarchar(max) null,
		[Old] nvarchar(max) not null,
		[New] nvarchar(max) not null,
		constraint [PK_Records] primary key ([Id]),
		constraint [FK_Records_Athletes_AthleteId] foreign key ([AthleteId]) references [Athletes]([Id]),
		constraint [FK_Records_Federations_FederationId] foreign key ([FederationId]) references [Federations]([Id]),
		constraint [FK_Records_AgeGroups_AgeGroupId] foreign key ([AgeGroupId]) references [AgeGroups]([Id])
	);
end;

-- Construction Projects Tables
if not exists (
	select * from sys.objects
		where name = 'ConstructionProjects' and type = 'U'
)
begin
	create table [ConstructionProjects] (
		[Id] uniqueidentifier default newid() not null,
		[Title] nvarchar(256) not null,
		[CityId] int not null,
		[IsRural] bit null,
		[IsRenovation] bit not null,
		[TypeId] int not null,
		[StartYear] int not null,
		[Area] int null,
		[SportArea] int null,
		constraint [PK_ConstructionProjects] primary key ([Id]),
		constraint [FK_ConstructionProjects_Cities_CityId] foreign key ([CityId]) references [Cities]([Id]),
		constraint [FK_ConstructionProjects_FacilityTypes_TypeId] foreign key ([TypeId]) references [FacilityTypes]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'ProjectUserGeneders' and type = 'U'
)
begin
	create table [ProjectUserGeneders] (
		[ProjectId] uniqueidentifier not null,
		[GenderId] int not null,
		constraint [PK_ProjectUserGenders] primary key ([ProjectId], [GenderId]),
		constraint [FK_ProjectUserGenders_ConstructionProjects_ProjectId] foreign key ([ProjectId]) references [ConstructionProjects]([Id]),
		constraint [FK_ProjectUserGenders_Genders_GenderId] foreign key ([GenderId]) references [Genders]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'ProjectCompletionProgress' and type = 'U'
)
begin
	create table [ProjectCompletionProgress] (
		[ProjectId] uniqueidentifier not null,
		[Year] int not null,
		[Percentage] int default 0 not null,
		[CompletionYear] int null,
		constraint [PK_ProjectCompletionProgress] primary key ([ProjectId], [Percentage]),
		constraint [FK_ProjectCompletionProgress_ConstructionProjects_ProjectId] foreign key ([ProjectId]) references [ConstructionProjects]([Id])
	);
end;

if not exists (
	select * from sys.objects
		where name = 'ProjectBudgets' and type = 'U'
)
begin
	create table [ProjectBudgets] (
		[ProjectId] uniqueidentifier not null,
		[Year] int not null,
		[FundingSource] nvarchar(max) null,
		[ApprovedBudgets] int not null,
		[ContractorUnpaid] int default 0 null,
		[CompletionBudget] int default 0 null,
		constraint [PK_ProjectBudgets] primary key ([ProjectId], [Year]),
		constraint [FK_ProjectBudgets_ConstructionProjects_ProjectId] foreign key ([ProjectId]) references [ConstructionProjects]([Id])
	);
end;
