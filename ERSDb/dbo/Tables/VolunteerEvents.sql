CREATE TABLE [dbo].[VolunteerEvents] (
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
    [NonProfit]           NCHAR (50)    NULL,
    [NonProfitId]         INT           NULL,
    [EventLocked]         BIT           NULL,
    [EventHidden]         BIT           NULL
);