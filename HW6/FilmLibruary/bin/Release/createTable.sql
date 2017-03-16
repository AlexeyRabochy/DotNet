CREATE TABLE [dbo].[Actor] (
    [Id]   INT          NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Actor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Films] (
    [Id]       INT          NOT NULL,
    [Picture]  VARCHAR (50) NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Country]  VARCHAR (50) NOT NULL,
    [Year]     INT          NOT NULL,
    [Producer] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Films] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ActorToFilm] (
    [Id]      INT NOT NULL,
    [FilmId]  INT NOT NULL,
    [ActorId] INT NOT NULL,
    CONSTRAINT [PK_ActorToFilm] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ActorToFilm_Actor] FOREIGN KEY ([ActorId]) REFERENCES [dbo].[Actor] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ActorToFilm_Films] FOREIGN KEY ([FilmId]) REFERENCES [dbo].[Films] ([Id]) ON DELETE CASCADE
);

