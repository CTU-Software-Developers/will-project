CREATE TABLE [dbo].[Comments]
(
	[userID] INT NOT NULL , 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Question1] NVARCHAR(50) NULL, 
    [Question2] NVARCHAR(50) NULL, 
    [Question3] NCHAR(10) NULL, 
    CONSTRAINT [PK_Comments] PRIMARY KEY ([userID]) 
)
