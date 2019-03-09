CREATE TABLE [dbo].[VolunteerEvents] (
    [VolunteerEventId]             INT           IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [EventName]           VARCHAR (MAX)    NULL,
    [EventDescription]    VARCHAR (MAX) NULL,
    [EventDate]           DATETIME      NULL,
    [EventStartTime]      DATETIME      NULL,
    [EventEndTime]        DATETIME      NULL,
    [EventDetails]        VARCHAR (MAX)  NULL,
    [EventInterest]       INT  NULL,
    [EventFiles]          VARCHAR (MAX)  NULL,
    [EventTotalTime]      INT           NULL,
    [EventCapacity]       INT           NULL,
    [Company]             VARCHAR (MAX)    NULL,
    [RestrictedByCompany] BIT           NULL,
    [NonProfit]           VARCHAR (MAX)    NULL,
    [NonProfitId]         INT           NULL,
    [EventLocked]         BIT           NULL,
    [EventHidden]         BIT           NULL
);