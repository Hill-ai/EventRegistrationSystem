CREATE TABLE [dbo].[UsersVolunteerEvents]
(
	[UserId] NVARCHAR (128) Not Null,
	[VolunteerEventId] INT Not Null, 
    CONSTRAINT [FK_UsersVolunteerEvents_AspNetUsers] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers]([Id]), 
    CONSTRAINT [FK_UsersVolunteerEvents_VolunteerEvents] FOREIGN KEY ([VolunteerEventId]) REFERENCES [VolunteerEvents]([VolunteerEventId])


)
