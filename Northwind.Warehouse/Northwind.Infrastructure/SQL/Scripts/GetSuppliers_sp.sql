/****** Object:  StoredProcedure [dbo].[GetSuppliers_sp] ******/
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetSuppliers_sp]') AND type in (N'P', N'PC'))
	DROP PROCEDURE [dbo].[GetSuppliers_sp]
GO

CREATE PROCEDURE [dbo].[GetSuppliers_sp]
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

	END
GO