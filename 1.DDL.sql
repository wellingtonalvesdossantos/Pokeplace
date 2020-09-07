use Pokeplace
go

create table PrivacityLevel
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_PrivacityLevel PRIMARY KEY ([Id])
)
go

create table Team
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_Team PRIMARY KEY ([Id])
)
go

create table Gym
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(64) NOT NULL,
	Latitude DECIMAL(9,6) NOT NULL,
	Longitude DECIMAL(9,6) NOT NULL,
	Ativo BIT NOT NULL,
	CONSTRAINT PK_Gym PRIMARY KEY ([Id])
)
go

create table Pokestop
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(64) NOT NULL,
	Latitude DECIMAL(9,6) NOT NULL,
	Longitude DECIMAL(9,6) NOT NULL,
	Ativo BIT NOT NULL,
	CONSTRAINT PK_Pokestop PRIMARY KEY ([Id])
)
go

create table Trainer
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(64) NOT NULL,
	Apelido NVARCHAR(64) NOT NULL,
	Codigo NVARCHAR(16) NOT NULL,
	Nivel TINYINT NOT NULL,
	TeamId INT NOT NULL,
	Ativo BIT NOT NULL,
	Celular NVARCHAR(32) NULL,
	Email NVARCHAR(64) NULL,
	CONSTRAINT PK_Trainer PRIMARY KEY ([Id]),
	CONSTRAINT FK_Trainer_Team FOREIGN KEY ([TeamId]) REFERENCES Team ([Id])
)
go

create table TrainerConfig
(
	Id INT IDENTITY(1,1) NOT NULL,
	TrainerId INT NOT NULL,
	DisponivelRaidPresencial BIT NOT NULL,
	DisponivelRaidRemota BIT NOT NULL,
	CelularPrivacityLevelId INT NOT NULL,
	EmailPrivacityLevelId INT NOT NULL,
	CONSTRAINT PK_TrainerConfig PRIMARY KEY ([Id]),
	CONSTRAINT FK_TrainerConfig_Trainer FOREIGN KEY ([TrainerId]) REFERENCES Trainer ([Id]),
	CONSTRAINT FK_TrainerConfig_CelularPrivacityLevel FOREIGN KEY ([CelularPrivacityLevelId]) REFERENCES PrivacityLevel ([Id]),
	CONSTRAINT FK_TrainerConfig_EmailPrivacityLevel FOREIGN KEY ([EmailPrivacityLevelId]) REFERENCES PrivacityLevel ([Id]),
)
go

create table PokemonType
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(20) NOT NULL,
	CONSTRAINT PK_PokemonType PRIMARY KEY ([Id])
)
go

create table Pokemon
(
	Id INT IDENTITY(1,1) NOT NULL,
	Nome NVARCHAR(64) NOT NULL,
	Numero INT NOT NULL,
	MainTypeId INT NOT NULL,
	SecondTypeId INT NULL,
	ATK INT NULL,
	DEF INT NULL,
	STA INT NULL,
	CONSTRAINT PK_Pokemon PRIMARY KEY ([Id]),
	CONSTRAINT FK_Pokemon_MainPokemonType FOREIGN KEY ([MainTypeId]) REFERENCES PokemonType ([Id]),
	CONSTRAINT FK_Pokemon_SecondPokemonType FOREIGN KEY ([SecondTypeId]) REFERENCES PokemonType ([Id]),
)
go

create table RaidBoss
(
	Id INT IDENTITY(1,1) NOT NULL,
	PokemonId INT NOT NULL,
	Ativo BIT NOT NULL,
	CP INT NULL,
	CONSTRAINT PK_RaidBoss PRIMARY KEY ([Id]),
	CONSTRAINT FK_RaidBoss_Pokemon FOREIGN KEY ([PokemonId]) REFERENCES Pokemon ([Id]),
)
go

create table Raid
(
	Id INT IDENTITY(1,1) NOT NULL,
	Inicio SMALLDATETIME NOT NULL,
	GymId INT NOT NULL,
	Registro DATETIME NOT NULL,
	TrainerId INT NOT NULL,
	RaidBossId INT NULL,
	CONSTRAINT PK_Raid PRIMARY KEY ([Id]),
	CONSTRAINT FK_Raid_RaidBoss FOREIGN KEY ([RaidBossId]) REFERENCES RaidBoss ([Id]),
	CONSTRAINT FK_Raid_Gym FOREIGN KEY ([GymId]) REFERENCES Gym ([Id]),
)
go

create table RaidMember
(
	Id INT IDENTITY(1,1) NOT NULL,
	Registro DATETIME NOT NULL,
	RaidId INT NOT NULL,
	TrainerId INT NOT NULL,
	PrecisaConvite BIT NOT NULL,
	ConviteTrainerId INT NULL,
	CONSTRAINT PK_RaidMember PRIMARY KEY ([Id]),
	CONSTRAINT FK_RaidMember_Raid FOREIGN KEY ([TrainerId]) REFERENCES Raid ([Id]),
	CONSTRAINT FK_RaidMember_Trainer FOREIGN KEY ([TrainerId]) REFERENCES Trainer ([Id]),
	CONSTRAINT FK_RaidMember_ConviteTrainer FOREIGN KEY ([ConviteTrainerId]) REFERENCES Trainer ([Id]),
)
go