using Csla;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.Infrastructure.Security;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Products
{
    [Serializable()]
    public class ProductEdit : Infrastructure.CslaBaseTypes.BusinessBase<ProductEdit>
    {
        public static readonly PropertyInfo<byte[]> TimeStampProperty = RegisterProperty<byte[]>(c => c.TimeStamp);
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] TimeStamp
        {
            get { return GetProperty(TimeStampProperty); }
            set { SetProperty(TimeStampProperty, value); }
        }

        public static readonly PropertyInfo<int> ProductIDProperty = RegisterProperty<int>(c => c.ProductID);
        [Display(Name = "Product ID")]
        public int ProductID
        {
            get { return GetProperty(ProductIDProperty); }
            set { SetProperty(ProductIDProperty, value); }
        }

        public static readonly PropertyInfo<string> ProductNameProperty = RegisterProperty<string>(c => c.ProductName);
        [Display(Name = "Product Name")]
        [Required]
        [StringLength(40)]
        public string ProductName
        {
            get { return GetProperty(ProductNameProperty); }
            set { SetProperty(ProductNameProperty, value); }
        }

        public static readonly PropertyInfo<Int32?> SupplierIDProperty = RegisterProperty<Int32?>(c => c.SupplierID);
        [Required]
        [Display(Name = "Supplier ID")]
        public Int32? SupplierID
        {
            get { return GetProperty(SupplierIDProperty); }
            set { SetProperty(SupplierIDProperty, value); }
        }
        
        public static readonly PropertyInfo<Int32?> CategoryIDProperty = RegisterProperty<Int32?>(c => c.CategoryID);
        [Required]
        [Display(Name = "Category ID")]
        public Int32? CategoryID
        {
            get { return GetProperty(CategoryIDProperty); }
            set { SetProperty(CategoryIDProperty, value); }
        }

        public static readonly PropertyInfo<string> QuantityPerUnitProperty = RegisterProperty<string>(c => c.QuantityPerUnit);
        [Display(Name = "Quantity Per Unit")]
        [StringLength(20)]
        public string QuantityPerUnit
        {
            get { return GetProperty(QuantityPerUnitProperty); }
            set { SetProperty(QuantityPerUnitProperty, value); }
        }

        public static readonly PropertyInfo<decimal?> UnitPriceProperty = RegisterProperty<decimal?>(c => c.UnitPrice);
        [Display(Name = "Unit Price")]
        public decimal? UnitPrice
        {
            get { return GetProperty(UnitPriceProperty); }
            set { SetProperty(UnitPriceProperty, value); }
        }

        public static readonly PropertyInfo<short?> UnitsInStockProperty = RegisterProperty<short?>(c => c.UnitsInStock);
        [Display(Name = "Units In Stock")]
        public short? UnitsInStock
        {
            get { return GetProperty(UnitsInStockProperty); }
            set { SetProperty(UnitsInStockProperty, value); }
        }

        public static readonly PropertyInfo<short?> UnitsOnOrderProperty = RegisterProperty<short?>(c => c.UnitsOnOrder);
        [Display(Name = "Units On Order")]
        public short? UnitsOnOrder
        {
            get { return GetProperty(UnitsOnOrderProperty); }
            set { SetProperty(UnitsOnOrderProperty, value); }
        }

        public static readonly PropertyInfo<short?> ReorderLevelProperty = RegisterProperty<short?>(c => c.ReorderLevel);
        [Display(Name = "Reorder Level")]
        public short? ReorderLevel
        {
            get { return GetProperty(ReorderLevelProperty); }
            set { SetProperty(ReorderLevelProperty, value); }
        }

        public static readonly PropertyInfo<bool> DiscontinuedProperty = RegisterProperty<bool>(c => c.Discontinued);
        [Display(Name = "Discontinued")]
        public bool Discontinued
        {
            get { return GetProperty(DiscontinuedProperty); }
            set { SetProperty(DiscontinuedProperty, value); }
        }

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, ProductNameProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, QuantityPerUnitProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, UnitPriceProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, UnitsInStockProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, UnitsOnOrderProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, ReorderLevelProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, DiscontinuedProperty, Roles.WarehouseManager));
        }

        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [ObjectAuthorizationRules]
        public static void AddObjectAuthorizationRules()
        {
            Csla.Rules.BusinessRules.AddRule(typeof(ProductEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(ProductEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(ProductEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, Roles.WarehouseManager));
        }

        public static async Task<ProductEdit> NewProductEditAsync()
        {
            return await DataPortal.CreateAsync<ProductEdit>();
        }

        public static async Task<ProductEdit> GetProductEditAsync(int id)
        {
            return await DataPortal.FetchAsync<ProductEdit>(id);
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            ProductExistsCommand cmd = await DataPortal.CreateAsync<ProductExistsCommand>(id);
            cmd = await DataPortal.ExecuteAsync(cmd);
            return cmd.ProductExists;
        }

        public static ProductEdit NewProductEdit()
        {
            return DataPortal.Create<ProductEdit>();
        }

        public static ProductEdit GetProductEdit(int id)
        {
            return DataPortal.Fetch<ProductEdit>(id);
        }

        public static void DeleteProductEdit(int id)
        {
            DataPortal.Delete<ProductEdit>(id);
        }

        public static async Task DeleteProductEditAsync(int id)
        {
            await DataPortal.DeleteAsync<ProductEdit>(id);
        }

        [RunLocal]
        [Create]
        private void Create()
        {
            BusinessRules.CheckRules();
        }

        [Fetch]
        private void Fetch(int id, [Inject] IProductDAL dal)
        {
            var data = dal.Fetch(id);
            using (BypassPropertyChecks)
            {
                ProductID = data.ProductID;
                ProductName = data.ProductName;
                SupplierID = data.SupplierID;
                CategoryID = data.CategoryID;
                QuantityPerUnit = data.QuantityPerUnit;
                UnitPrice = data.UnitPrice;
                UnitsInStock = data.UnitsInStock;
                UnitsOnOrder = data.UnitsOnOrder;
                ReorderLevel = data.ReorderLevel;
                Discontinued = data.Discontinued;
                TimeStamp = data.LastChanged;
            }
        }

        [Insert]
        private void Insert([Inject] IProductDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toInsert = new Productdto
                {
                    ProductName = this.ProductName,
                    SupplierID = this.SupplierID,
                    CategoryID = this.CategoryID,
                    QuantityPerUnit = this.QuantityPerUnit,
                    UnitPrice = this.UnitPrice,
                    UnitsInStock = this.UnitsInStock,
                    UnitsOnOrder = this.UnitsOnOrder,
                    ReorderLevel = this.ReorderLevel,
                    Discontinued = this.Discontinued
                };
                dal.Insert(toInsert);
                ProductID = toInsert.ProductID;
                TimeStamp = toInsert.LastChanged;
            }
        }

        [Update]
        private void Update([Inject] IProductDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toUpdate = new Productdto
                {
                    ProductID = this.ProductID,
                    ProductName = this.ProductName,
                    SupplierID = this.SupplierID,
                    CategoryID = this.CategoryID,
                    QuantityPerUnit = this.QuantityPerUnit,
                    UnitPrice = this.UnitPrice,
                    UnitsInStock = this.UnitsInStock,
                    UnitsOnOrder = this.UnitsOnOrder,
                    ReorderLevel = this.ReorderLevel,
                    Discontinued = this.Discontinued,
                    LastChanged = this.TimeStamp
                };
                dal.Update(toUpdate);
                TimeStamp = toUpdate.LastChanged;
            }
        }

        [DeleteSelf]
        private void DeleteSelf([Inject] IProductDAL dal)
        {
            using (BypassPropertyChecks)
            {
                Delete(this.ProductID, dal);
            }
        }

        [Delete]
        private void Delete(int id, [Inject] IProductDAL dal)
        {
            dal.Delete(id);
        }
    }
}