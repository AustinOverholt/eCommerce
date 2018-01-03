CREATE PROC [dbo].[AspNetUsers_SelectAll]

/*
Procedure for selecting all users in .Net default application
EXECUTE dbo.AspNetUsers_SelectAll
*/

AS

SELECT [Id]
      ,[Email]
      ,[EmailConfirmed]
      ,[PasswordHash]
      ,[SecurityStamp]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[TwoFactorEnabled]
      ,[LockoutEndDateUtc]
      ,[LockoutEnabled]
      ,[AccessFailedCount]
      ,[UserName]
  FROM [dbo].[AspNetUsers]

