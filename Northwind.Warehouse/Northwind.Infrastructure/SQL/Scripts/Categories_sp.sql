/****** Object:  StoredProcedure [dbo].[CategoryExists] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CategoryExists]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[CategoryExists]
GO

CREATE PROCEDURE [dbo].[CategoryExists]
    @CategoryId int
AS
    BEGIN

        SET NOCOUNT ON

        IF EXISTS ( SELECT 1 AS Exist FROM [dbo].[Categories] WHERE [CategoryID] = @CategoryId)
            BEGIN
                RETURN 1
            END

            ELSE RETURN 0
    END
GO


/****** Object:  StoredProcedure [dbo].[GetCategoryByID] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCategoryByID]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetCategoryByID]
GO

CREATE PROCEDURE [dbo].[GetCategoryByID]
    @CategoryId int
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [CategoryID]
            ,[CategoryName]
            ,[Description]
            ,[Picture]
            ,[LastChanged]
        FROM [dbo].[Categories]
        WHERE
            [CategoryID] = @CategoryId

    END
GO

/****** Object:  StoredProcedure [dbo].[GetCategoryByName] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetCategoryByName]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetCategoryByName]
GO

CREATE PROCEDURE [dbo].[GetCategoryByName]
    @CategoryName int
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [CategoryID]
            ,[CategoryName]
            ,[Description]
            ,[Picture]
            ,[LastChanged]
        FROM [dbo].[Categories]
        WHERE
            [CategoryName] LIKE '%'+@CategoryName+'%'

    END
GO

/****** Object:  StoredProcedure [dbo].[AddCategory] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddCategory]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddCategory]
GO

CREATE PROCEDURE [dbo].[AddCategory]
    @CategoryID [INT],
	@CategoryName [NVARCHAR](15),
	@Description [NTEXT],
	@Picture [IMAGE]
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object  */
       INSERT INTO [dbo].[Categories]
           ([CategoryName]
           ,[Description]
           ,[Picture])
        VALUES
        (
          @CategoryName
           ,@Description
           ,@Picture
         )

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateCategory] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateCategory]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateCategory]
GO

CREATE PROCEDURE [dbo].[UpdateCategory]
    @CategoryID [INT],
	@CategoryName [NVARCHAR](15),
	@Description [NTEXT],
	@Picture [IMAGE]
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [CategoryID] FROM [dbo].[CategoryID]
            WHERE
                [CategoryID] = @CategoryID
        )
        BEGIN
            RAISERROR ('''dbo.Categories'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object */
        UPDATE [dbo].[Users]
        SET
            [CategoryID] = @CategoryID,
	        [CategoryName] = @CategoryName,
	        [Description] = @Description,
	        [Picture] = @Picture
        WHERE
            [CategoryID] = @CategoryID
		  
            IF @@ROWCOUNT = 0
				BEGIN
					RAISERROR('Row has been edited by another user', 16, 1)
					RETURN
				END
    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteCategory] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteCategory]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteCategory]
GO

CREATE PROCEDURE [dbo].[DeleteCategory]
    @CategoryId int
AS
    BEGIN

        SET NOCOUNT ON

        DELETE [dbo].[Categories]
        WHERE
            [CategoryID] = @CategoryId
        RETURN
    END
GO