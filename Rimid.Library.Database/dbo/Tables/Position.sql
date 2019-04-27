CREATE TABLE [dbo].[Position] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [NamePosition] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED ([Id] ASC)
);

