CREATE TABLE [dbo].[Companies](
	[CompanyID] [int] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[PrimaryContactName] [nvarchar](100) NOT NULL,
	[PrimaryContactPhoneNumber] [nvarchar](100) NULL,
	[PrimaryContactEmail] [nvarchar](100) NOT NULL,
	[CompanyWebLink] [nvarchar](100) NULL,
);
