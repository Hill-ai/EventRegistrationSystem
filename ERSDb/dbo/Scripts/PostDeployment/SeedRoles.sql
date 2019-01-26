IF OBJECT_ID('tempdb..#tempRoles') IS NOT NULL
	DROP TABLE #tempRoles

CREATE TABLE #tempRoles (
    [Id]   NVARCHAR (128) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL,
);

INSERT INTO #tempRoles (Id, Name)
VALUES ( '9360859A-BA7F-4462-A2DB-07B13889C97C', 'ADMIN');

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
