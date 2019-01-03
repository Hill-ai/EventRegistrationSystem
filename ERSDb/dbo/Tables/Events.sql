CREATE TABLE [dbo].[Events] (
    [EventId]             INT           NOT NULL,
    [EventName]           NCHAR (20)    NULL,
    [EventDescription]    VARCHAR (MAX) NULL,
    [EventDate]           DATETIME      NULL,
    [EventStartTime]      DATETIME      NULL,
    [EventEndTime]        DATETIME      NULL,
    [EventDetails]        VARCHAR (50)  NULL,
    [EventInterest]       VARCHAR (50)  NULL,
    [EventFiles]          VARCHAR (50)  NULL,
    [EventTotalTime]      INT           NULL,
    [EventCapacity]       INT           NULL,
    [Company]             NCHAR (10)    NULL,
    [RestrictedByCompany] BIT           NULL,
    [NonProfit]           NCHAR (10)    NULL,
    [NonProfitId]         INT           NULL,
    [EventLocked]         BIT           NULL,
    [EventHidden]         BIT           NULL
);