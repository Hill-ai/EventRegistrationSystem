IF OBJECT_ID('tempdb..#tempVolunteerEvents') IS NOT NULL
	DROP TABLE #tempVolunteerEvents

CREATE TABLE #tempVolunteerEvents(
    [VolunteerEventId]             INT           IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [EventName]           NCHAR (50)    NULL,
    [EventDescription]    VARCHAR (MAX) NULL,
    [EventDate]           DATETIME      NULL,
    [EventStartTime]      DATETIME      NULL,
    [EventEndTime]        DATETIME      NULL,
    [EventDetails]        VARCHAR (50)  NULL,
    [EventInterest]       INT  NULL,
    [EventFiles]          VARCHAR (50)  NULL,
    [EventTotalTime]      INT           NULL,
    [EventCapacity]       INT           NULL,
    [Company]             NCHAR (50)    NULL,
    [RestrictedByCompany] BIT           NULL,
    
    [NonProfitId]         INT           NULL,
    [EventLocked]         BIT           NULL,
    [EventHidden]         BIT           NULL
);

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'eventname 1' , 'description ev1', '12/04/2018', '12/04/2018 10:00', '12/04/2018 1:00', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'eventname 2', 'description ev2', '12/11/2018', '12/11/2018 11:00', '12/11/2018 2:00', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'eventname 3', 'description ev3', '12/01/2018', '12/01/2018 9:00', '12/01/2018 12:00', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'eventname 4', 'description ev4', '12/10/2018', '12/10/2018 1:00', '12/10/2018 4:00', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );


MERGE INTO  dbo.VolunteerEvents AS target
USING #tempVolunteerEvents AS source
	ON source.VolunteerEventId = target.VolunteerEventId
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		
		[EventName]          ,
		[EventDescription]    ,
		[EventDate]           ,
		[EventStartTime]      ,
		[EventEndTime]        ,
		[EventDetails]        ,
		[EventInterest]       ,
		[EventFiles]          ,
		[EventTotalTime]      ,
		[EventCapacity]       ,
		[Company]             ,
		[RestrictedByCompany] ,
		
		[NonProfitId]         ,
		[EventLocked]         ,
		[EventHidden]         
		)
	VALUES
	(
		
		source.[EventName]          ,
		source.[EventDescription]    ,
		source.[EventDate]           ,
		source.[EventStartTime]      ,
		source.[EventEndTime]        ,
		source.[EventDetails]        ,
		source.[EventInterest]       ,
		source.[EventFiles]          ,
		source.[EventTotalTime]      ,
		source.[EventCapacity]       ,
		source.[Company]             ,
		source.[RestrictedByCompany] ,
		
		source.[NonProfitId]         ,
		source.[EventLocked]         ,
		source.[EventHidden]  
	);

DROP TABLE #tempVolunteerEvents
			



