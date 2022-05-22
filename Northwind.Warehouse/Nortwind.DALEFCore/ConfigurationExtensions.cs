
using Microsoft.Extensions.DependencyInjection;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DbContexts;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DALEFCore
{
    /// <summary>
    /// Configuration extension methods
    /// </summary>
    public static class ConfigurationExtensions
    {
        public static void AddDALEFCore(this IServiceCollection services)
        {
            services.AddScoped<NorthwindContext>();
            services.AddTransient<ICategoryDAL, CategoryDAL>();
            services.AddTransient<IProductDAL, ProductDAL>();
            services.AddTransient<IRoleDal, RoleDal>();
            services.AddTransient<ISupplierDAL, SupplierDAL>();
            services.AddTransient<IUserDal, UserDal>();
        }
    }
}
