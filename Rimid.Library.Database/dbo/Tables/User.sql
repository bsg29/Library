CREATE TABLE [dbo].[User] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Login]      VARCHAR (15) NOT NULL,
    [Password]   VARCHAR (32) NOT NULL,
    [UserDataId] INT          NOT NULL,
    [PositionId] INT          NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_User_User] FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([Id]),
    CONSTRAINT [FK_User_UserData] FOREIGN KEY ([UserDataId]) REFERENCES [dbo].[UserData] ([Id])
);

