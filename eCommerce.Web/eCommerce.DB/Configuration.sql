CREATE TABLE [dbo].[Configuration]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ConfigName] NVARCHAR(MAX) NOT NULL, 
    [ConfigValue] NVARCHAR(MAX) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [DateCreated] DATETIME2 NOT NULL DEFAULT GetUTCDATE(), 
    [DateModified] DATETIME2 NULL, 
    [DataType] NVARCHAR(10) NOT NULL, 
    [Category] NVARCHAR(10) NULL
)
