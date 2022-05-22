/****** Object:  StoredProcedure [dbo].[GetUserRoles_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRoles_sp]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[GetUserRoles_sp]
GO

CREATE PROCEDURE [dbo].[GetUserRoles_sp]
AS
	BEGIN

		SET NOCOUNT ON

		SELECT [Role]
            ,[Username]
        FROM [dbo].[UserRoles]

	END
GO

/****** Object:  StoredProcedure [dbo].[GetUserRoless_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRoles_sp]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetUserRoles_sp]
GO

CREATE PROCEDURE [dbo].[GetUserRoles_sp]
    @Role VARCHAR(20)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [Role]
            ,[Username]
        FROM [dbo].[UserRoles]
        WHERE
            [Role] = @Role
    END
GO