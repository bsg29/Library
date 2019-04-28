CREATE TABLE [dbo].[ClientLog] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [IssueDate]   SMALLDATETIME NOT NULL,
    [ReturnDate]  SMALLDATETIME NOT NULL,
    [IsReturned]  TINYINT       NOT NULL,
    [ClientId]    INT           NOT NULL,
    [BookPrintId] INT           NOT NULL,
    [BookId]      INT           NOT NULL,
    [UserId]	  INT           NOT NULL,
    CONSTRAINT [PK_ClientLog] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClientLog_BookPrint] FOREIGN KEY ([BookPrintId]) REFERENCES [dbo].[BookPrint] ([Id]),
    CONSTRAINT [FK_ClientLog_Client] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]),
    CONSTRAINT [FK_ClientLog_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
);

