IF OBJECT_ID('tempdb..#tempCompanies') IS NOT NULL
	DROP TABLE #tempCompanies

CREATE TABLE #tempCompanies (
    [CompanyID]                 INT            IDENTITY (1, 1) NOT NULL,
    [Name]                      NVARCHAR (100) NOT NULL,
    [Address]                   NVARCHAR (500) NOT NULL,
    [PhoneNumber]               NVARCHAR (50)  NOT NULL,
    [Email]                     NVARCHAR (100) NOT NULL,
    [PrimaryContactName]        NVARCHAR (100) NOT NULL,
    [PrimaryContactPhoneNumber] NVARCHAR (100) NULL,
    [PrimaryContactEmail]       NVARCHAR (100) NOT NULL,
    [CompanyWebLink]            NVARCHAR (100) NULL
);

INSERT INTO #tempCompanies (CompanyID, Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink)
VALUES ('Penatibus Company', 'Ap #565-1530 Elit, Street', '(896) 317-7876', 'dui@nibhPhasellusnulla.org', 'Lawrence', '(669) 844-6856', 'ante.iaculis@est.net', 'Shay');

MERGE INTO  dbo.Company AS target
USING #tempCompanies AS source
	ON source.CompanyID = target.CompanyID
WHEN NOT MATCHED BY TARGET THEN 
	INSERT 
	( 
		[Name], 
		[Address], 
		[PhoneNumber], 
		[Email], 
		[PrimaryContactName], 
		[PrimaryContactPhoneNumber], 
		[PrimaryContactEmail], 
		[CompanyWebLink]
		)
	VALUES
	(
		source.[Name], 
		source.[Address], 
		source.[PhoneNumber], 
		source.[Email], 
		source.[PrimaryContactName], 
		source.[PrimaryContactPhoneNumber], 
		source.[PrimaryContactEmail], 
		source.[CompanyWebLink]
	);

DROP TABLE #tempCompanies
			



