CREATE TABLE [dbo].[NonProfits]
(
	[NonProfitId] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(200) NOT NULL, 
    [Address] NVARCHAR(100) NOT NULL, 
    [City] NVARCHAR(200) NOT NULL, 
    [Zip] NVARCHAR(10) NOT NULL, 
    [Phone] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(100) NOT NULL, 
    [PrimaryContactName] NVARCHAR(200) NULL, 
    [PrimaryContactPhone] NVARCHAR(50) NULL, 
    [PrimaryContactEmail] NVARCHAR(100) NULL, 
    [WebLink] NVARCHAR(200) NULL
)
