/****** Object:  StoredProcedure [dbo].[GetCategories_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCategories_sp]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[GetCategories_sp]
GO

CREATE PROCEDURE [dbo].[GetCategories_sp]
AS
	BEGIN

		SET NOCOUNT ON

		SELECT [CategoryID]
			,[CategoryName]
			,[Description]
			,[Picture]
			,[LastChanged]
		FROM [dbo].[Categories]

	END
GO