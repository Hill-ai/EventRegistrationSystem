IF OBJECT_ID('tempdb..#tempAspNetUsers') IS NOT NULL
	DROP TABLE #tempAspNetUsers

CREATE TABLE #tempAspNetUsers (
    [Id]                   NVARCHAR (128) NOT NULL,
    [Email]                NVARCHAR (256) NULL,
    [EmailConfirmed]       BIT            DEFAULT ((1)) NOT NULL,
    [PasswordHash]         NVARCHAR (MAX) NULL,
    [SecurityStamp]        NVARCHAR (MAX) NULL,
    [PhoneNumber]          NVARCHAR (MAX) NULL,
    [PhoneNumberConfirmed] BIT            NOT NULL,
    [TwoFactorEnabled]     BIT            NOT NULL,
    [LockoutEndDateUtc]    DATETIME       NULL,
    [LockoutEnabled]       BIT            NOT NULL,
    [AccessFailedCount]    INT            NOT NULL,
    [UserName]             NVARCHAR (256) NOT NULL,
    [FirstName]            NVARCHAR (128) NOT NULL,
    [LastName]             NVARCHAR (128) NOT NULL,
    [Address]              NVARCHAR (128) NULL,
    [City]                 NVARCHAR (128) NULL,
    [Zip]                  NVARCHAR (128) NULL,
    [State]                NVARCHAR (128) NULL,
    [CompanyId]            INT            NOT NULL,
    [IsActive]             BIT            DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetUsers_Companies] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Companies] ([CompanyID])
);

INSERT INTO #tempAspNetUsers (Id, Email, EmailConfirmed, PasswordHash, SecurityStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEndDateUtc, LockoutEnabled, AccessFailedCount, UserName, FirstName, LastName, Address, City, Zip, State, CompanyID, IsActive)
VALUES (N'1966aaa6-d351-467f-989e-dd43a96dfcbf', N'marcopolo@whereswaldo.com', 0, N'ANIXvvqm8oQt8Q7qQ2EtF9/mtgFdEMaNALzDF3sycPskbyvKFyGCLOBkxrkZw8plHQ==', N'045b787d-a2e4-45e9-9060-4a8238934010', NULL, 0, 0, NULL, 1, 0, N'marcopolo@whereswaldo.com', N'Marco', N'Polo', N'1234 Maple Street', N'Jacksonville', N'32223', N'FL', 11, 1);

MERGE INTO  dbo.AspNetUsers AS target
USING #tempAspNetUsers AS source
	ON source.Id = target.Id
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		[Id],  
        [Email], 
		[EmailConfirmed], 
		[PasswordHash], 
		[SecurityStamp], 
		[PhoneNumber], 
		[PhoneNumberConfirmed], 
		[TwoFactorEnabled], 
		[LockoutEndDateUtc], 
		[LockoutEnabled], 
		[AccessFailedCount], 
		[UserName], 
		[FirstName], 
		[LastName], 
		[Address], 
		[City], 
		[Zip], 
		[State], 
		[CompanyId], 
		[IsActive]
		)
	VALUES
	(
		source.[Id],  
        source.[Email], 
		source.[EmailConfirmed], 
		source.[PasswordHash], 
		source.[SecurityStamp], 
		source.[PhoneNumber], 
		source.[PhoneNumberConfirmed], 
		source.[TwoFactorEnabled], 
		source.[LockoutEndDateUtc], 
		source.[LockoutEnabled], 
		source.[AccessFailedCount], 
		source.[UserName], 
		source.[FirstName], 
		source.[LastName], 
		source.[Address], 
		source.[City], 
		source.[Zip], 
		source.[State], 
		source.[CompanyId], 
		source.[IsActive]
	);

DROP TABLE #tempAspNetUsers


