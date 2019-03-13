CREATE TABLE [dbo].[CompanyContracts]
(
	[CompanyContractID]		INT				    NOT NULL	IDENTITY,
	[CompanyID]				INT                 NOT NULL,
	[ContractToken]			UNIQUEIDENTIFIER	NOT NULL DEFAULT NEWID(),
	[IsActive]				BIT				    NOT NULL DEFAULT 1,	
	[ContractStartDate]		DATETIME			NOT NULL,
	[ContractEndDate]		DATETIME			NOT NULL,
	[ContractCapacity]		INT					NOT NULL DEFAULT 0,

	CONSTRAINT [PK_dbo.CompanyContracts] PRIMARY KEY CLUSTERED ([CompanyContractID] ASC),
	CONSTRAINT [FK_CompanyContracts_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID])
)
