CREATE TABLE [dbo].[Publisher] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [NamePublisher] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED ([Id] ASC)
);

