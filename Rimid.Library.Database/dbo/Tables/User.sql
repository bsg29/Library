CREATE TABLE [dbo].[User] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Login]      VARCHAR (15) NOT NULL,
    [Password]   VARCHAR (32) NOT NULL,
    [PositionId] INT          NOT NULL,
	[FirstName]  VARCHAR (50) NOT NULL,
    [MiddleName] VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Phone]      NCHAR (10)   NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_Position] FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([Id])
);

