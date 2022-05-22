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
    #region SupplierADONetDAL
    public class SupplierADONetDAL : ISupplierDAL
    {
        public IConfiguration Configuration { get; }
        public SupplierADONetDAL(IConfiguration configuration)
        {
            Configuration = configuration; 
        }

        public List<Supplierdto> Fetch()
        {
            List<Supplierdto> toReturn = new List<Supplierdto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetSuppliers_sp", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var _supplier = new Supplierdto
                            {
                                SupplierID = dr.GetInt32("SupplierID"),
                                CompanyName = dr.GetString("CompanyName"),
                                ContactName = dr.GetString("ContactName"),
                                ContactTitle = dr.GetString("ContactTitle"),
                                Address = dr.GetString("Address"),
                                City = dr.GetString("City"),
                                Region = dr.GetString("Region"),
                                PostalCode = dr.GetString("PostalCode"),
                                Country = dr.GetString("Country"),
                                Phone = dr.GetString("Phone"),
                                Fax = dr.GetString("Fax"),
                                HomePage = dr.GetString("HomePage"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_supplier);
                        }
                    }
                }
            }

            return toReturn;
        }

        public List<Supplierdto> Fetch(string nameFilter)
        {
            List<Supplierdto> toReturn = new List<Supplierdto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetSupplierByName", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompanyName", nameFilter).DbType = DbType.String;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var _supplier = new Supplierdto
                            {
                                SupplierID = dr.GetInt32("SupplierID"),
                                CompanyName = dr.GetString("CompanyName"),
                                ContactName = dr.GetString("ContactName"),
                                ContactTitle = dr.GetString("ContactTitle"),
                                Address = dr.GetString("Address"),
                                City = dr.GetString("City"),
                                Region = dr.GetString("Region"),
                                PostalCode = dr.GetString("PostalCode"),
                                Country = dr.GetString("Country"),
                                Phone = dr.GetString("Phone"),
                                Fax = dr.GetString("Fax"),
                                HomePage = dr.GetString("HomePage"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_supplier);
                        }
                    }
                }
            }

            return toReturn;
        }

        public Supplierdto Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetSupplierByID", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", id).DbType = DbType.Int32;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            var _supplier = new Supplierdto
                            {
                                SupplierID = dr.GetInt32("SupplierID"),
                                CompanyName = dr.GetString("CompanyName"),
                                ContactName = dr.GetString("ContactName"),
                                ContactTitle = dr.GetString("ContactTitle"),
                                Address = dr.GetString("Address"),
                                City = dr.GetString("City"),
                                Region = dr.GetString("Region"),
                                PostalCode = dr.GetString("PostalCode"),
                                Country = dr.GetString("Country"),
                                Phone = dr.GetString("Phone"),
                                Fax = dr.GetString("Fax"),
                                HomePage = dr.GetString("HomePage"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            return _supplier;
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
                using (var cmd = new SqlCommand("dbo.SupplierExists", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", id).DbType = DbType.Int32;

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

        public void Insert(Supplierdto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.AddSupplier", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompanyName", item.CompanyName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ContactName", String.IsNullOrEmpty(item.ContactName) ? (object)DBNull.Value : item.ContactName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ContactTitle", String.IsNullOrEmpty(item.ContactTitle) ? (object)DBNull.Value : item.ContactTitle).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Address", String.IsNullOrEmpty(item.Address) ? (object)DBNull.Value : item.Address).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@City", String.IsNullOrEmpty(item.City) ? (object)DBNull.Value : item.City).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Region", String.IsNullOrEmpty(item.Region) ? (object)DBNull.Value : item.Region).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@PostalCode", String.IsNullOrEmpty(item.PostalCode) ? (object)DBNull.Value : item.PostalCode).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Country", String.IsNullOrEmpty(item.Country) ? (object)DBNull.Value : item.Country).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Phone", String.IsNullOrEmpty(item.Phone) ? (object)DBNull.Value : item.Phone).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Fax", String.IsNullOrEmpty(item.Fax) ? (object)DBNull.Value : item.Fax).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HomePage", String.IsNullOrEmpty(item.HomePage) ? (object)DBNull.Value : item.HomePage).DbType = DbType.String;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Update(Supplierdto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.UpdateSupplier", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CompanyName", item.CompanyName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ContactTitle", String.IsNullOrEmpty(item.ContactTitle) ? (object)DBNull.Value : item.ContactTitle).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Address", String.IsNullOrEmpty(item.Address) ? (object)DBNull.Value : item.Address).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@City", String.IsNullOrEmpty(item.City) ? (object)DBNull.Value : item.City).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Region", String.IsNullOrEmpty(item.Region) ? (object)DBNull.Value : item.Region).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@PostalCode", String.IsNullOrEmpty(item.PostalCode) ? (object)DBNull.Value : item.PostalCode).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Country", String.IsNullOrEmpty(item.Country) ? (object)DBNull.Value : item.Country).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Phone", String.IsNullOrEmpty(item.Phone) ? (object)DBNull.Value : item.Phone).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Fax", String.IsNullOrEmpty(item.Fax) ? (object)DBNull.Value : item.Fax).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@HomePage", String.IsNullOrEmpty(item.HomePage) ? (object)DBNull.Value : item.HomePage).DbType = DbType.String;
                   
                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.DeleteSupplier", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SupplierId", id).DbType = DbType.Int32;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }
    }
    #endregion
}
