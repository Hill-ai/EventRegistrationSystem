IF OBJECT_ID('tempdb..#tempCompanies') IS NOT NULL
	DROP TABLE #tempCompanies

CREATE TABLE #tempCompanies (
    [CompanyID]                 INT            IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [Name]                      NVARCHAR (100) NOT NULL,
    [Address]                   NVARCHAR (500) NOT NULL,
    [PhoneNumber]               NVARCHAR (50)  NOT NULL,
    [Email]                     NVARCHAR (100) NOT NULL,
    [PrimaryContactName]        NVARCHAR (100) NOT NULL,
    [PrimaryContactPhoneNumber] NVARCHAR (100) NOT NULL,
    [PrimaryContactEmail]       NVARCHAR (100) NOT NULL,
    [CompanyWebLink]            NVARCHAR (100) NULL,
	[IsActive]					BIT			   NOT NULL
);

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Dui LLP','712-4654 Metus Ave','(897) 416-5834','pharetra@euplacerateget.net','Echo','(753) 126-1651','lectus.convallis.est@Vivamusmolestiedapibus.net','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Semper Tellus Id PC','P.O. Box 402, 324 Dictum. Road','(608) 299-3147','lacus@elitCurabitur.ca','Isaac','(997) 178-8316','et@egetmassa.net','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Lorem Ipsum Sodales Industries','822-9264 Duis Av.','(401) 543-3043','est.Mauris.eu@Craspellentesque.ca','Oren','(248) 830-1628','nibh.Phasellus@necorciDonec.co.uk','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Nonummy Ut Molestie Ltd','Ap #903-6625 Eget Road','(533) 202-5013','Etiam.gravida.molestie@ornareliberoat.com','Mollie','(298) 192-9200','Aliquam@neccursus.com','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Quis Incorporated','Ap #314-5281 Commodo St.','(101) 801-0931','pede.blandit@tellus.com','Catherine','(312) 230-9999','dapibus.quam@interdumligulaeu.co.uk','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Erat In Consectetuer Incorporated','Ap #238-1013 Massa. Rd.','(694) 687-7855','Quisque.varius.Nam@massaMauris.co.uk','Claudia','(641) 186-1712','Vivamus@fringilla.edu','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Nullam Velit Industries','8206 Euismod St.','(896) 526-2542','adipiscing@orcilacusvestibulum.edu','Ian','(298) 696-7869','eget.laoreet.posuere@aliquameu.com','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Ac Company','Ap #260-4692 Congue, Avenue','(809) 293-6368','dictum.magna.Ut@DonecegestasDuis.org','James','(760) 179-0114','sit.amet@nec.co.uk','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Quisque LLP','Ap #938-3676 Ultricies St.','(814) 517-5517','accumsan.convallis.ante@aliquetPhasellusfermentum.org','Fallon','(150) 253-8116','leo.in@mauris.com','https://www.microsoft.com/en-us/','1');

INSERT INTO #tempCompanies (Name, Address, PhoneNumber, Email, PrimaryContactName, PrimaryContactPhoneNumber, PrimaryContactEmail, CompanyWebLink, IsActive)
VALUES ('Mi Felis Adipiscing LLP','Ap #319-4312 Et Ave','(958) 600-5620','Aliquam@eget.com','Whitney','(834) 788-1610','Duis@augueSedmolestie.net','https://www.microsoft.com/en-us/','1');

MERGE INTO  dbo.Companies AS target
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
		[CompanyWebLink],
		[IsActive]
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
		source.[CompanyWebLink],
		source.[IsActive]
	);

DROP TABLE #tempCompanies
			



