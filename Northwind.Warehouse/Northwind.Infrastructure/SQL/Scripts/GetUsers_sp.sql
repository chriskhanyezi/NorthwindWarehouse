/****** Object:  StoredProcedure [dbo].[GetUsers_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUsers_sp]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[GetUsers_sp]
GO

CREATE PROCEDURE [dbo].[GetUsers_sp]
AS
	BEGIN

		SET NOCOUNT ON

		SELECT [Username]
               ,[Password]
        FROM [dbo].[Users]

	END
GO

/****** Object:  StoredProcedure [dbo].[GetUsers_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUsers_sp]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetUsers_sp]
GO

CREATE PROCEDURE [dbo].[GetUsers_sp]
    @Username VARCHAR(20)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [Username]
               ,[Password]
        FROM [dbo].[Users]
        WHERE
            [Username] = @Username
    END
GO