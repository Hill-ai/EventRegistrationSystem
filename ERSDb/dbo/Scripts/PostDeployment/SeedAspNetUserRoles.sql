IF OBJECT_ID('tempdb..#tempAspNetUserRoles') IS NOT NULL
	DROP TABLE #tempAspNetUserRoles

CREATE TABLE #tempAspNetUserRoles (
    [UserId] NVARCHAR (128) NOT NULL,
    [RoleId] NVARCHAR (128) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED ([UserId] ASC, [RoleId] ASC),
    CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE
);

INSERT INTO #tempAspNetUserRoles ([UserId], [RoleId])
VALUES (N'1966aaa6-d351-467f-989e-dd43a96dfcbf', N'9360859A-BA7F-4462-A2DB-07B13889C97C');

MERGE INTO  dbo.AspNetUserRoles AS target
USING #tempAspNetUserRoles AS source
	ON source.UserID = target.UserID
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		[UserId],
		[RoleID]
		)
	VALUES
	(
		source.[UserID], 
		source.[RoleID]
	);

DROP TABLE #tempAspNetUserRoles
