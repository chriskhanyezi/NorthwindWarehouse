/****** Object:  StoredProcedure [dbo].[SupplierExists] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SupplierExists]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[SupplierExists]
GO

CREATE PROCEDURE [dbo].[SupplierExists]
    @SupplierId int
AS
    BEGIN

        SET NOCOUNT ON

        IF EXISTS ( SELECT 1 AS Exist FROM [dbo].[Suppliers] WHERE [SupplierID] = @SupplierId)
            BEGIN
                RETURN 1
            END

            ELSE RETURN 0
    END
GO


/****** Object:  StoredProcedure [dbo].[GetSupplierByName] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSupplierByName]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetSupplierByName]
GO

CREATE PROCEDURE [dbo].[GetSupplierByName]
    @CompanyName [NVARCHAR](40)
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [SupplierID]
          ,[CompanyName]
          ,[ContactName]
          ,[ContactTitle]
          ,[Address]
          ,[City]
          ,[Region]
          ,[PostalCode]
          ,[Country]
          ,[Phone]
          ,[Fax]
          ,[HomePage]
          ,[LastChanged]
      FROM [dbo].[Suppliers]
        WHERE
            [CompanyName] LIKE '%' + @CompanyName + '%'

    END
GO


/****** Object:  StoredProcedure [dbo].[GetSupplierByID] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSupplierByID]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetSupplierByID]
GO

CREATE PROCEDURE [dbo].[GetSupplierByID]
    @SupplierId int
AS
    BEGIN

        SET NOCOUNT ON

        SELECT [SupplierID]
          ,[CompanyName]
          ,[ContactName]
          ,[ContactTitle]
          ,[Address]
          ,[City]
          ,[Region]
          ,[PostalCode]
          ,[Country]
          ,[Phone]
          ,[Fax]
          ,[HomePage]
          ,[LastChanged]
      FROM [dbo].[Suppliers]
        WHERE
            [SupplierID] = @SupplierId

    END
GO

/****** Object:  StoredProcedure [dbo].[AddSupplier] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddSupplier]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddSupplier]
GO

CREATE PROCEDURE [dbo].[AddSupplier]
    @CompanyName [NVARCHAR](40),
	@ContactName [NVARCHAR](30),
	@ContactTitle [NVARCHAR](30),
	@Address [NVARCHAR](60),
	@City [NVARCHAR](15),
	@Region [NVARCHAR](15),
	@PostalCode [NVARCHAR](10),
	@Country [NVARCHAR](15),
	@Phone [NVARCHAR](24),
	@Fax [NVARCHAR](24),
	@HomePage [NTEXT]
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.Suppliers */
       INSERT INTO [dbo].[Suppliers]
           ([CompanyName]
          ,[ContactName]
          ,[ContactTitle]
          ,[Address]
          ,[City]
          ,[Region]
          ,[PostalCode]
          ,[Country]
          ,[Phone]
          ,[Fax]
          ,[HomePage])
        VALUES
        (
           @CompanyName
          ,@ContactName
          ,@ContactTitle
          ,@Address
          ,@City
          ,@Region
          ,@PostalCode
          ,@Country
          ,@Phone
          ,@Fax
          ,@HomePage
         )

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateSupplier] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateSupplier]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateSupplier]
GO

CREATE PROCEDURE [dbo].[UpdateSupplier]
    @SupplierID [INT],
    @CompanyName [NVARCHAR](40),
	@ContactName [NVARCHAR](30),
	@ContactTitle [NVARCHAR](30),
	@Address [NVARCHAR](60),
	@City [NVARCHAR](15),
	@Region [NVARCHAR](15),
	@PostalCode [NVARCHAR](10),
	@Country [NVARCHAR](15),
	@Phone [NVARCHAR](24),
	@Fax [NVARCHAR](24),
	@HomePage [NTEXT]
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [SupplierID] FROM [dbo].[SupplierID]
            WHERE
                [SupplierID] = @SupplierID
        )
        BEGIN
            RAISERROR ('''dbo.Suppliers'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object */
        UPDATE [dbo].[Suppliers]
        SET
            [CompanyName]= @CompanyName,
	        [ContactName]= @ContactName,
	        [ContactTitle]= @ContactTitle,
	        [Address]= @Address,
	        [City]= @City,
	        [Region]= @Region,
	        [PostalCode]= @PostalCode,
	        [Country]= @Country,
	        [Phone]= @Phone,
	        [Fax]= @Fax,
	        [HomePage]= @HomePage
        WHERE
            [SupplierID] = @SupplierID
		  
            IF @@ROWCOUNT = 0
				BEGIN
					RAISERROR('Row has been edited by another user', 16, 1)
					RETURN
				END
    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteSupplier] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteSupplier]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteSupplier]
GO

CREATE PROCEDURE [dbo].[DeleteSupplier]
    @SupplierId int
AS
    BEGIN

        SET NOCOUNT ON

        DELETE [dbo].[Suppliers]
        WHERE
            [SupplierID] = @SupplierId
        RETURN
    END
GO