/****** Object:  StoredProcedure [dbo].[UserLogin] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserLogin]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UserLogin]
GO

CREATE PROCEDURE [dbo].[UserLogin]
    @user varchar(20),
    @pw varchar(20)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [Username]
        FROM [dbo].[Users]
        WHERE [Username]=@user AND [Password]=@pw;
    END
GO

/****** Object:  StoredProcedure [dbo].[GetUserRoles] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUserRoles]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetUserRoles]
GO

CREATE PROCEDURE [dbo].[GetUserRoles]
    @user varchar(20)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT R.[Role]
        FROM Users AS U INNER JOIN [dbo].[UserRoles] AS R ON
        R.[UserName] = U.[UserName]
        WHERE U.Username = @user

    END
GO