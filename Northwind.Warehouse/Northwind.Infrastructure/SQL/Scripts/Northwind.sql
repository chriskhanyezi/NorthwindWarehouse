CREATE TABLE [dbo].[Categories](
	[CategoryID] [INT] IDENTITY(1,1) NOT NULL,
	[CategoryName] [NVARCHAR](15) NOT NULL,
	[Description] [NTEXT] NULL,
	[Picture] [IMAGE] NULL,
	[LastChanged] [TIMESTAMP] NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryID] ASC)
) 

GO

CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [INT] IDENTITY(1,1) NOT NULL,
	[CompanyName] [NVARCHAR](40) NOT NULL,
	[ContactName] [NVARCHAR](30) NULL,
	[ContactTitle] [NVARCHAR](30) NULL,
	[Address] [NVARCHAR](60) NULL,
	[City] [NVARCHAR](15) NULL,
	[Region] [NVARCHAR](15) NULL,
	[PostalCode] [NVARCHAR](10) NULL,
	[Country] [NVARCHAR](15) NULL,
	[Phone] [NVARCHAR](24) NULL,
	[Fax] [NVARCHAR](24) NULL,
	[HomePage] [NTEXT] NULL,
	[LastChanged] [TIMESTAMP] NOT NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED ([SupplierID] ASC)
) 

GO

CREATE TABLE [dbo].[Products](
	[ProductID] [INT] IDENTITY(1,1) NOT NULL,
	[ProductName] [NVARCHAR](40) NOT NULL,
	[SupplierID] [INT] NULL,
	[CategoryID] [INT] NULL,
	[QuantityPerUnit] [NVARCHAR](20) NULL,
	[UnitPrice] [MONEY] NULL CONSTRAINT [DF_Products_UnitPrice]  DEFAULT (0),
	[UnitsInStock] [SMALLINT] NULL CONSTRAINT [DF_Products_UnitsInStock]  DEFAULT (0),
	[UnitsOnOrder] [SMALLINT] NULL CONSTRAINT [DF_Products_UnitsOnOrder]  DEFAULT (0),
	[ReorderLevel] [SMALLINT] NULL CONSTRAINT [DF_Products_ReorderLevel]  DEFAULT (0),
	[Discontinued] [BIT] NOT NULL CONSTRAINT [DF_Products_Discontinued]  DEFAULT (0),
	[LastChanged] [TIMESTAMP] NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductID] ASC)
) 

GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_Products_UnitPrice] CHECK  (([UnitPrice] >= 0))
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_UnitPrice]
GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_ReorderLevel] CHECK  (([ReorderLevel] >= 0))
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_ReorderLevel]
GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsInStock] CHECK  (([UnitsInStock] >= 0))
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_UnitsInStock]
GO

ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsOnOrder] CHECK  (([UnitsOnOrder] >= 0))
GO

ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_UnitsOnOrder]
GO