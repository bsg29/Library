MERGE INTO [dbo].[Position] AS Target
USING (VALUES
	(1,N'Администратор'),
	(2,N'Библиотекарь')
) AS Source ([Id],[Name])
ON (Target.[Id] = Source.[Id])
WHEN MATCHED THEN
	UPDATE SET
		[Name] = Source.[Name]
WHEN NOT MATCHED BY TARGET THEN
	INSERT([Id],[Name])
	VALUES(
		Source.[Id],
		Source.[Name]
	)
WHEN NOT MATCHED BY Source THEN
	DELETE;
GO