CREATE TABLE [dbo].[BookPrint] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [PublishDate] DATE           NOT NULL,
    [PublisherId] INT            NOT NULL,
    [Price]       DECIMAL (7, 2) NOT NULL,
    [BookId]      INT            NOT NULL,
    CONSTRAINT [PK_BookPrint] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_BookPrint_BookPrint] FOREIGN KEY ([BookId]) REFERENCES [dbo].[Book] ([Id]),
    CONSTRAINT [FK_BookPrint_Publisher] FOREIGN KEY ([PublisherId]) REFERENCES [dbo].[Publisher] ([Id])
);

