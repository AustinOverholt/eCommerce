CREATE PROC [dbo].[Configuration_SelectAll]

/*
Execute Configuration_SelectAll
*/

AS
SELECT [Id]
      ,[ConfigName]
      ,[ConfigValue]
      ,[Description]
      ,[DateCreated]
      ,[DateModified]
      ,[DataType]
      ,[Category]
  FROM [dbo].[Configuration]
GO


