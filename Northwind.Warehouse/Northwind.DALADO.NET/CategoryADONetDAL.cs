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
    #region CategoryADONetDAL

    public class CategoryADONetDAL : ICategoryDAL
    {
        public IConfiguration Configuration { get; }

        public CategoryADONetDAL(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public List<Categorydto> Fetch()
        {
            List<Categorydto> toReturn = new List<Categorydto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetCategories_sp", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        while (dr.Read())
                        {
                            var _category = new Categorydto 
                            {
                                CategoryID = dr.GetInt32("CategoryID"),
                                CategoryName = dr.GetString("CategoryName"),
                                Description = dr.GetString("Description"),
                                Picture = (byte[])dr.GetValue("Picture"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_category);
                        }
                    }
                }
            }

            return toReturn;
        }

        public List<Categorydto> Fetch(string nameFilter)
        {
            List<Categorydto> toReturn = new List<Categorydto>();

            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.CategoryName_sp", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryName", nameFilter).DbType = DbType.String;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            var _category = new Categorydto
                            {
                                CategoryID = dr.GetInt32("CategoryID"),
                                CategoryName = dr.GetString("CategoryName"),
                                Description = dr.GetString("Description"),
                                Picture = (byte[])dr.GetValue("Picture"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            toReturn.Add(_category);
                        }
                    }
                }
            }

            return toReturn;
        }

        public Categorydto Fetch(int id)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.GetCategoryByID", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", id).DbType = DbType.Int32;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            var _category = new Categorydto
                            {
                                CategoryID = dr.GetInt32("CategoryID"),
                                CategoryName = dr.GetString("CategoryName"),
                                Description = dr.GetString("Description"),
                                Picture = (byte[])dr.GetValue("Picture"),
                                LastChanged = (byte[])dr.GetValue("LastChanged")
                            };

                            return _category;
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
                using (var cmd = new SqlCommand("dbo.CategoryExists", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", id).DbType = DbType.Int32;

                    using (var dr = new SafeDataReader(cmd.ExecuteReader()))
                    {
                        if (dr.Read())
                        {
                            exists =  dr.GetBoolean("Exist");

                            return exists;
                        }
                    }
                }
            }
           
            return false;
        }

        public void Insert(Categorydto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.AddCategory", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID).DbType = DbType.Int32 ;
                    cmd.Parameters.AddWithValue("@CategoryName", item.CategoryName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Description", String.IsNullOrEmpty(item.Description) ? (object)DBNull.Value : item.Description).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Picture",item.Picture);
                
                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Update(Categorydto item)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.UpdateCategory", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryID", item.CategoryID).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@CategoryName", item.CategoryName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Description", String.IsNullOrEmpty(item.Description) ? (object)DBNull.Value : item.Description).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Picture", item.Picture).DbType = DbType.Object;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Configuration.GetConnectionString("NorthwindConnection"), false))
            {
                using (var cmd = new SqlCommand("dbo.DeleteCategory", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CategoryId", id).DbType = DbType.Int32;

                    cmd.ExecuteNonQuery();
                }
                ctx.Commit();
            }
        }
    }
    #endregion
}
