CREATE TABLE [dbo].[Client] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]  VARCHAR (50) NOT NULL,
    [MiddleName] VARCHAR (50) NOT NULL,
    [LastName]   VARCHAR (50) NOT NULL,
    [Address]    VARCHAR (50) NOT NULL,
    [Phone]      NCHAR (10)   NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Id] ASC)
);

