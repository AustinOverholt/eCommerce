CREATE Proc [dbo].[Configuration_Insert]
	@ConfigName nvarchar(max),
	@ConfigValue nvarchar(max),
	@Description nvarchar(max),
	@DataType nvarchar(10),
	@Category nvarchar(10),
	@Id int OUTPUT

/*
Select * From dbo.Configuration

	Declare  @_id int = 0
	Declare  @_configName nvarchar(max) = 'test',
		 @_configValue nvarchar(max) = 'test',
		 @_description nvarchar(max) = 'test',
		 @_datatype nvarchar(10) = 'string',
		 @_category nvarchar(10) = 'connection'
	Execute dbo.Configuration_Insert
		 @_configName,
		 @_configValue,
		 @_description,
		 @_datatype,
		 @_category,
		 @_id OUTPUT

Select * From dbo.Configuration


*/

AS
BEGIN
INSERT INTO [dbo].[Configuration]
           ([ConfigName]
           ,[ConfigValue]
           ,[Description]
           ,[DataType]
           ,[Category])
     VALUES
			(@ConfigName,
            @ConfigValue,
			@Description,
			@DataType,
			@Category)
			SET @Id = SCOPE_IDENTITY();
END




