using Csla.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace Northwind.DALADO.NET
{
    #region ProductADONetDAL
    public class ProductADONetDAL : IProductDAL
    {
        public IConfiguration Configuration { get; }

        public ProductADONetDAL(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<Productdto> Fetch()
        {
            List<Productdto> toReturn = new List<Productdto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetProducts_sp", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var _product = new Productdto
                            {
                                ProductID = dr.GetInt32("ProductID"),
                                ProductName = dr.GetString("ProductName"),
                                SupplierID = dr.GetInt32("SupplierID"),
                                CategoryID = dr.GetInt32("CategoryID"),
                                QuantityPerUnit = dr.GetString("ProductName"),
                                UnitPrice = dr.GetDecimal("UnitPrice"),
                                UnitsInStock = dr.GetInt16("UnitsInStock"),
                                UnitsOnOrder = dr.GetInt16("UnitsOnOrder"),
                                ReorderLevel = dr.GetInt16("ReorderLevel"),
                                Discontinued = dr.GetBoolean("Discontinued"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_product);
                        }
                    }
                }
            }

            return toReturn;
        }

        public List<Productdto> Fetch(string nameFilter)
        {
            List<Productdto> toReturn = new List<Productdto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetProductByName", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductName", nameFilter).DbType = DbType.String;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var _product = new Productdto
                            {
                                ProductID = dr.GetInt32("ProductID"),
                                ProductName = dr.GetString("ProductName"),
                                SupplierID = dr.GetInt32("SupplierID"),
                                CategoryID = dr.GetInt32("CategoryID"),
                                QuantityPerUnit = dr.GetString("ProductName"),
                                UnitPrice = dr.GetDecimal("UnitPrice"),
                                UnitsInStock = dr.GetInt16("UnitsInStock"),
                                UnitsOnOrder = dr.GetInt16("UnitsOnOrder"),
                                ReorderLevel = dr.GetInt16("ReorderLevel"),
                                Discontinued = dr.GetBoolean("Discontinued"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_product);
                        }
                    }
                }
            }

            return toReturn;
        }

        public Productdto Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetProductByID", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", id).DbType = DbType.Int32;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            var _product = new Productdto
                            {
                                ProductID = dr.GetInt32("ProductID"),
                                ProductName = dr.GetString("ProductName"),
                                SupplierID = dr.GetInt32("SupplierID"),
                                CategoryID = dr.GetInt32("CategoryID"),
                                QuantityPerUnit = dr.GetString("ProductName"),
                                UnitPrice = dr.GetDecimal("UnitPrice"),
                                UnitsInStock = dr.GetInt16("UnitsInStock"),
                                UnitsOnOrder = dr.GetInt16("UnitsOnOrder"),
                                ReorderLevel = dr.GetInt16("ReorderLevel"),
                                Discontinued = dr.GetBoolean("Discontinued"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            return _product;
                        }
                    }
                }
            }
            return null;
        }

        public bool Exists(int id)
        {
            bool exists = false;

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.ProductExists", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", id).DbType = DbType.Int32;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            exists = dr.GetBoolean("Exist");

                            return exists;
                        }
                    }
                }
            }

            return false;
        }

        public void Insert(Productdto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.AddProduct", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductName", item.ProductName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SupplierID", item.SupplierID).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", String.IsNullOrEmpty(item.QuantityPerUnit) ? (object)DBNull.Value : item.QuantityPerUnit).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice == null ? (object)DBNull.Value : item.UnitPrice).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock == null ? (object)DBNull.Value : item.UnitsInStock).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", item.UnitsOnOrder == null ? (object)DBNull.Value : item.UnitsOnOrder).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@ReorderLevel", item.ReorderLevel == null ? (object)DBNull.Value :item.ReorderLevel).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@Discontinued", item.Discontinued).DbType = DbType.Boolean;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Update(Productdto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.UpdateProduct", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductName", item.ProductName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@SupplierID", item.SupplierID).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@QuantityPerUnit", String.IsNullOrEmpty(item.QuantityPerUnit) ? (object)DBNull.Value : item.QuantityPerUnit).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice).DbType = DbType.Decimal;
                    cmd.Parameters.AddWithValue("@UnitsInStock", item.UnitsInStock).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@UnitsOnOrder", item.UnitsOnOrder).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@ReorderLevel", item.ReorderLevel).DbType = DbType.Int16;
                    cmd.Parameters.AddWithValue("@Discontinued", item.Discontinued).DbType = DbType.Boolean;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.DeleteProduct", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProductId", id).DbType = DbType.Int32;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }
    }
    #endregion
}
