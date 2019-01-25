IF OBJECT_ID('tempdb..#tempRoles') IS NOT NULL
	DROP TABLE #tempRoles

CREATE TABLE #tempRoles (
    [Id]   NVARCHAR (128) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL,
);

INSERT INTO #tempRoles (Id, Name)
VALUES ( NEWID(), 'ADMIN');

MERGE INTO  dbo.AspNetRoles AS target
USING #tempRoles AS source
	ON source.Id = target.Id
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		[Id],  
        [Name] 
		)
	VALUES
	(
		source.[Id], 
		source.[Name] 
	);

DROP TABLE #tempRoles
