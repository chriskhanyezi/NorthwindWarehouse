/****** Object:  StoredProcedure [dbo].[GetProducts_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetProducts_sp]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[GetProducts_sp]
GO

CREATE PROCEDURE [dbo].[GetProducts_sp]
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

	END
GO