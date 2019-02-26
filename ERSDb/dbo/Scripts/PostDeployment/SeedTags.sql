IF OBJECT_ID('tempdb..#tempTags') IS NOT NULL
	DROP TABLE #tempTags

CREATE TABLE #tempTags(
    [TagId]             INT           IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [TagDescription] VARCHAR (50) NOT NULL
);

INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Clean up Jacksonville');


INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Community Outreach');


INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Veterans');

INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Homelessness');




INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Troubled youth');

INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Humanitarian');

INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Humane Society');

INSERT INTO #tempTags ( TagDescription)
VALUES ( 'Disaster preparedness');






MERGE INTO  dbo.Tags AS target
USING #tempTags AS source
	ON source.TagId = target.TagId
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		
		[TagDescription]          
         
		)
	VALUES
	(
		
		source.[TagDescription] 
	);

DROP TABLE #tempTags
			



