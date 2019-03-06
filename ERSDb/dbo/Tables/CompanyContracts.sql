CREATE TABLE [dbo].[CompanyContracts]
(
	[CompanyContractID]		INT				    NOT NULL,
	[CompanyID]				INT                 NOT NULL,
	[ContractToken]			UNIQUEIDENTIFIER	NOT NULL DEFAULT NEWID(),
	[IsActive]				BIT				    NOT NULL DEFAULT 1,	
	[ContractStartDate]		DATETIME			NULL,
	[ContractEndDate]		DATETIME			NULL,
	[ContractCapacity]		INT					NOT NULL DEFAULT 0,

	CONSTRAINT [PK_dbo.CompanyContracts] PRIMARY KEY CLUSTERED ([CompanyContractID] ASC),
	CONSTRAINT [FK_CompanyContracts_Companies] FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID])
)
