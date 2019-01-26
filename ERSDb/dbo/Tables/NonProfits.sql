CREATE TABLE [dbo].[NonProfits]
(
	[NonProfitId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Address] NVARCHAR(100) NULL, 
    [City] NVARCHAR(200) NULL, 
    [Zip] NVARCHAR(10) NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [PrimaryContactName] NVARCHAR(200) NULL, 
    [PrimaryContactPhone] NVARCHAR(50) NULL, 
    [PrimaryContactEmail] NVARCHAR(100) NULL, 
    [WebLink] NVARCHAR(200) NULL
)
