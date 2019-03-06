CREATE TABLE [dbo].[UserRegistrations]
(
	[UserRegistrationID]	INT	   			    NOT NULL,
	[CompanyContractID]		INT				    NOT NULL,
	[Id]					NVARCHAR (128)	    NOT NULL,
	[DateCreated]			DATE				NOT NULL DEFAULT GETDATE(),
	[IsActive]				BIT				    NOT NULL DEFAULT 1,

	CONSTRAINT [PK_dbo.UserRegistrations] PRIMARY KEY CLUSTERED ([UserRegistrationID] ASC),
	CONSTRAINT [FK_UserRegistrations_CompanyContracts] FOREIGN KEY ([CompanyContractID]) REFERENCES [dbo].[CompanyContracts] ([CompanyContractID]),
	CONSTRAINT [FK_UserRegistrations_AspNetUsers] FOREIGN KEY ([Id]) REFERENCES [dbo].[AspNetUsers] ([Id])
)
