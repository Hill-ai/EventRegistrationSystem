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
VALUES ( 'EFG eventname 1' , 'description ev1', '12/04/2019', '12/04/2019 10:00', '12/04/2019 1:00 PM', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'XYZ eventname 2', 'description ev2', '12/11/2019', '12/11/2019 11:00', '12/11/2019 2:00 PM', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'XYZ eventname 3', 'description ev3', '11/01/2019', '11/01/2019 9:00', '11/01/2019 12:00 PM', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'ZYX eventname 4', 'description ev4', '12/10/2019', '12/10/2019 1:00', '12/10/2019 4:00 PM', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );




INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'ZYX eventname 5' , 'description ev5', '1/04/2019', '1/04/2019 10:00', '1/04/2019 1:00 PM', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'RTU eventname 6', 'description ev6', '2/11/2019', '2/11/2019 11:00', '2/11/2019 2:00 PM', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'DEF eventname 7', 'description ev7', '3/01/2019', '3/01/2019 9:00', '3/01/2019 12:00 PM', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'ABC eventname 8', 'description ev4', '3/10/2019', '3/10/2019 1:00', '3/10/2019 4:00 PM', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );




INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'QRS eventname 9' , 'description ev9', '4/04/2019', '4/04/2019 10:00', '4/04/2019 1:00 PM', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'QRS eventname 10', 'description ev10', '1/11/2019', '1/11/2019 11:00', '1/11/2019 2:00 PM', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'STU eventname 11', 'description ev11', '1/01/2019', '1/01/2019 9:00', '1/01/2019 12:00 PM', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'LMN eventname 12', 'description ev12', '6/10/2019', '6/10/2019 1:00 PM', '6/10/2019 4:00 PM', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );




INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'VXY eventname 13' , 'description ev13', '7/04/2019', '7/04/2019 10:00', '7/04/2019 1:00 PM', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'LMN eventname 14', 'description ev14', '8/11/2019', '8/11/2019 11:00', '8/11/2019 2:00 PM', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'GHI eventname 15', 'description ev15', '9/01/2019', '9/01/2019 9:00', '9/01/2019 12:00 PM', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'HIJ eventname 16', 'description ev16', '10/10/2019', '10/10/2019 1:00 PM', '10/10/2019 4:00 PM', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );





INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'RST eventname 17' , 'description ev17', '10/04/2019', '10/04/2019 10:00', '10/04/2019 1:00 PM', 'some details','3', 'some files', '6', '60', 'some company', '0', '8', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'NOP eventname 18', 'description ev18', '1/11/2019', '1/11/2019 11:00', '1/11/2019 2:00 PM', 'some details','3', 'some files', '9', '78', 'another company', '0', '3', '0', '0' );


INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany, NonProfitId, EventLocked, EventHidden)
VALUES ( 'QRS eventname 19', 'description ev19', '1/11/2019', '1/11/2019 9:00', '1/11/2019 12:00 PM', 'some details','3', 'some files', '7', '50', 'a different company', '0',  '9', '0', '0' );

INSERT INTO #tempVolunteerEvents ( EventName, EventDescription, EventDate, EventStartTime, EventEndTime, EventDetails, EventInterest, EventFiles, EventTotalTime, EventCapacity, Company, RestrictedByCompany,  NonProfitId, EventLocked, EventHidden)
VALUES ( 'BCD eventname 20', 'description ev20', '1/10/2019', '1/10/2019 1:00 PM', '1/10/2019 4:00 PM', 'some details','3', 'some files', '10', '80', 'some other company', '0', '12', '0', '0' );


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
			



