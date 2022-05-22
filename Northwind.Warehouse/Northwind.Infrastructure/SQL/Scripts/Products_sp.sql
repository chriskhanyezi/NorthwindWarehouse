/****** Object:  StoredProcedure [dbo].[ProductExists] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProductExists]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[ProductExists]
GO

CREATE PROCEDURE [dbo].[ProductExists]
    @ProductId int
AS
    BEGIN

        SET NOCOUNT ON

        IF EXISTS ( SELECT 1 AS Exist FROM [dbo].[Products] WHERE [ProductID] = @ProductId)
            BEGIN
                RETURN 1
            END

            ELSE RETURN 0
    END
GO

/****** Object:  StoredProcedure [dbo].[GetProductByID] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProductByID]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetProductByID]
GO

CREATE PROCEDURE [dbo].[GetProductByID]
    @ProductId int
AS
    BEGIN

        SET NOCOUNT ON

       SELECT [ProductID]
            ,[ProductName]
            ,[SupplierID]
            ,[CategoryID]
            ,[QuantityPerUnit]
            ,[UnitPrice]
            ,[UnitsInStock]
            ,[UnitsOnOrder]
            ,[ReorderLevel]
            ,[Discontinued]
            ,[LastChanged]
        FROM [dbo].[Products]
        WHERE
            [ProductID] = @ProductId

    END
GO


/****** Object:  StoredProcedure [dbo].[GetProductByName] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProductByName]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[GetProductByName]
GO

CREATE PROCEDURE [dbo].[GetProductByName]
    @ProductName VARCHAR(40)
AS
    BEGIN

        SET NOCOUNT ON

       SELECT [ProductID]
            ,[ProductName]
            ,[SupplierID]
            ,[CategoryID]
            ,[QuantityPerUnit]
            ,[UnitPrice]
            ,[UnitsInStock]
            ,[UnitsOnOrder]
            ,[ReorderLevel]
            ,[Discontinued]
            ,[LastChanged]
        FROM [dbo].[Products]
        WHERE
            [ProductName] LIKE  '%' + @ProductName + '%'

    END
GO

/****** Object:  StoredProcedure [dbo].[AddProduct] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddProduct]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[AddProduct]
GO

CREATE PROCEDURE [dbo].[AddProduct]
    @ProductName [NVARCHAR](40),
	@SupplierID [INT],
	@CategoryID [INT],
	@QuantityPerUnit [NVARCHAR](20),
	@UnitPrice [MONEY],
	@UnitsInStock [SMALLINT],
	@UnitsOnOrder [SMALLINT],
	@ReorderLevel [SMALLINT],
	@Discontinued [BIT]
AS
    BEGIN

        SET NOCOUNT ON

        /* Insert object into dbo.Products */
       INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[SupplierID]
           ,[CategoryID]
           ,[QuantityPerUnit]
           ,[UnitPrice]
           ,[UnitsInStock]
           ,[UnitsOnOrder]
           ,[ReorderLevel]
           ,[Discontinued])
        VALUES
        (
            @ProductName
           ,@SupplierID
           ,@CategoryID
           ,@QuantityPerUnit
           ,@UnitPrice
           ,@UnitsInStock
           ,@UnitsOnOrder
           ,@ReorderLevel
           ,@Discontinued
         )

    END
GO

/****** Object:  StoredProcedure [dbo].[UpdateProduct] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateProduct]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[UpdateProduct]
GO

CREATE PROCEDURE [dbo].[UpdateProduct]
    @ProductID [INT],
    @ProductName [NVARCHAR](40),
	@SupplierID [INT],
	@CategoryID [INT],
	@QuantityPerUnit [NVARCHAR](20),
	@UnitPrice [MONEY],
	@UnitsInStock [SMALLINT],
	@UnitsOnOrder [SMALLINT],
	@ReorderLevel [SMALLINT],
	@Discontinued [BIT]
AS
    BEGIN

        SET NOCOUNT ON

        /* Check for object existence */
        IF NOT EXISTS
        (
            SELECT [ProductID] FROM [dbo].[ProductID]
            WHERE
                [ProductID] = @ProductID
        )
        BEGIN
            RAISERROR ('''dbo.Products'' object not found. It was probably removed by another user.', 16, 1)
            RETURN
        END

        /* Update object */
        UPDATE [dbo].[Products]
        SET
            [ProductName] = @ProductName,
	        [SupplierID] = @SupplierID,
	        [CategoryID] = @CategoryID,
	        [QuantityPerUnit] = @QuantityPerUnit,
	        [UnitPrice] = @UnitPrice,
	        [UnitsInStock] = @UnitsInStock,
	        [UnitsOnOrder] = @UnitsOnOrder,
	        [ReorderLevel] = @ReorderLevel,
	        [Discontinued] = @Discontinued 
        WHERE
            [ProductID] = @ProductID
		  
            IF @@ROWCOUNT = 0
				BEGIN
					RAISERROR('Row has been edited by another user', 16, 1)
					RETURN
				END
    END
GO

/****** Object:  StoredProcedure [dbo].[DeleteProduct] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteProduct]') AND type in (N'P', N'PC'))
    DROP PROCEDURE [dbo].[DeleteProduct]
GO

CREATE PROCEDURE [dbo].[DeleteProduct]
    @ProductId int
AS
    BEGIN

        SET NOCOUNT ON

        DELETE [dbo].[Products]
        WHERE
            [ProductID] = @ProductId
        RETURN
    END
GO