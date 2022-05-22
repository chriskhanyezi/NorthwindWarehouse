using Csla;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.Infrastructure.Security;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Suppliers
{
    [Serializable()]
    public class SupplierEdit : Infrastructure.CslaBaseTypes.BusinessBase<SupplierEdit>
    {
        public static readonly PropertyInfo<byte[]> TimeStampProperty = RegisterProperty<byte[]>(c => c.TimeStamp);
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] TimeStamp
        {
            get { return GetProperty(TimeStampProperty); }
            set { SetProperty(TimeStampProperty, value); }
        }

        public static readonly PropertyInfo<int> SupplierIDProperty = RegisterProperty<int>(c => c.SupplierID);
        [Display(Name = "Supplier ID")]
        public int SupplierID
        {
            get { return GetProperty(SupplierIDProperty); }
            set { SetProperty(SupplierIDProperty, value); }
        }

        public static readonly PropertyInfo<string> CompanyNameProperty = RegisterProperty<string>(c => c.CompanyName);
        [Display(Name = "Company Name")]
        [Required]
        [StringLength(40)]
        public string CompanyName
        {
            get { return GetProperty(CompanyNameProperty); }
            set { SetProperty(CompanyNameProperty, value); }
        }

        public static readonly PropertyInfo<string> ContactNameProperty = RegisterProperty<string>(c => c.ContactName);
        [Display(Name = "Contact Name")]
        [StringLength(30)]
        public string ContactName
        {
            get { return GetProperty(ContactNameProperty); }
            set { SetProperty(ContactNameProperty, value); }
        }

        public static readonly PropertyInfo<string> ContactTitleProperty = RegisterProperty<string>(c => c.ContactTitle);
        [Display(Name = "Contact Title")]
        public string ContactTitle
        {
            get { return GetProperty(ContactTitleProperty); }
            set { SetProperty(ContactTitleProperty, value); }
        }

        public static readonly PropertyInfo<string> AddressProperty = RegisterProperty<string>(c => c.Address);
        [Display(Name = "Address")]
        [StringLength(60)]
        public string Address
        {
            get { return GetProperty(AddressProperty); }
            set { SetProperty(AddressProperty, value); }
        }

        public static readonly PropertyInfo<string> CityProperty = RegisterProperty<string>(c => c.City);
        [Display(Name = "City")]
        [StringLength(25)]
        public string City
        {
            get { return GetProperty(CityProperty); }
            set { SetProperty(CityProperty, value); }
        }

        public static readonly PropertyInfo<string> RegionProperty = RegisterProperty<string>(c => c.Region);
        [Display(Name = "Region")]
        [StringLength(25)]
        public string Region
        {
            get { return GetProperty(RegionProperty); }
            set { SetProperty(RegionProperty, value); }
        }

        public static readonly PropertyInfo<string> PostalCodeProperty = RegisterProperty<string>(c => c.PostalCode);
        [Display(Name = "PostalCode")]
        [StringLength(10)]
        public string PostalCode
        {
            get { return GetProperty(PostalCodeProperty); }
            set { SetProperty(PostalCodeProperty, value); }
        }

        public static readonly PropertyInfo<string> CountryProperty = RegisterProperty<string>(c => c.Country);
        [Display(Name = "Country")]
        [StringLength(15)]
        public string Country
        {
            get { return GetProperty(CountryProperty); }
            set { SetProperty(CountryProperty, value); }
        }

        public static readonly PropertyInfo<string> PhoneProperty = RegisterProperty<string>(c => c.Phone);
        [Display(Name = "Phone")]
        [StringLength(24)]
        public string Phone
        {
            get { return GetProperty(PhoneProperty); }
            set { SetProperty(PhoneProperty, value); }
        }

        public static readonly PropertyInfo<string> FaxProperty = RegisterProperty<string>(c => c.Fax);
        [Display(Name = "Fax")]
        [StringLength(24)]
        public string Fax
        {
            get { return GetProperty(FaxProperty); }
            set { SetProperty(FaxProperty, value); }
        }

        public static readonly PropertyInfo<string> HomePageProperty = RegisterProperty<string>(c => c.HomePage);
        [Display(Name = "HomePage")]
        public string HomePage
        {
            get { return GetProperty(HomePageProperty); }
            set { SetProperty(HomePageProperty, value); }
        }

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, CompanyNameProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, ContactNameProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, ContactTitleProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, AddressProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, CityProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, RegionProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, PostalCodeProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, CountryProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, PhoneProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, FaxProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, HomePageProperty, Roles.WarehouseManager));

        }

        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [ObjectAuthorizationRules]
        public static void AddObjectAuthorizationRules()
        {
            Csla.Rules.BusinessRules.AddRule(typeof(SupplierEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(SupplierEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(SupplierEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, Roles.WarehouseManager));
        }

        public static async Task<SupplierEdit> NewSupplierEditAsync()
        {
            return await DataPortal.CreateAsync<SupplierEdit>();
        }

        public static async Task<SupplierEdit> GetSupplierEditAsync(int id)
        {
            return await DataPortal.FetchAsync<SupplierEdit>(id);
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            SupplierExistsCommand cmd = await DataPortal.CreateAsync<SupplierExistsCommand>(id);
            cmd = await DataPortal.ExecuteAsync(cmd);
            return cmd.SupplierExists;
        }

        public static SupplierEdit NewSupplierEdit()
        {
            return DataPortal.Create<SupplierEdit>();
        }

        public static SupplierEdit GetSupplierEdit(int id)
        {
            return DataPortal.Fetch<SupplierEdit>(id);
        }

        public static void DeleteSupplierEdit(int id)
        {
            DataPortal.Delete<SupplierEdit>(id);
        }

        public static async Task DeleteSupplierEditAsync(int id)
        {
            await DataPortal.DeleteAsync<SupplierEdit>(id);
        }

        [RunLocal]
        [Create]
        private void Create()
        {
            BusinessRules.CheckRules();
        }

        [Fetch]
        private void Fetch(int id, [Inject] ISupplierDAL dal)
        {
            var data = dal.Fetch(id);
            using (BypassPropertyChecks)
            {
                SupplierID = data.SupplierID;
                CompanyName = data.CompanyName;
                ContactName = data.ContactName;
                ContactTitle = data.ContactTitle;
                Address = data.Address;
                City = data.City;
                Region = data.Region;
                PostalCode = data.PostalCode;
                Country = data.Country;
                Phone = data.Phone;
                Fax = data.Fax;
                HomePage = data.HomePage;
                TimeStamp = data.LastChanged;
            }
        }

        [Insert]
        private void Insert([Inject] ISupplierDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toInsert = new Supplierdto
                {
                    CompanyName = this.CompanyName,
                    ContactName = this.ContactName,
                    ContactTitle = this.ContactTitle,
                    Address = this.Address,
                    City = this.City,
                    Region = this.Region,
                    PostalCode = this.PostalCode,
                    Country = this.Country,
                    Phone = this.Phone,
                    Fax = this.Fax,
                    HomePage = this.HomePage
                };

                dal.Insert(toInsert);
                SupplierID = toInsert.SupplierID;
                TimeStamp = toInsert.LastChanged;
            }
        }

        [Update]
        private void Update([Inject] ISupplierDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toUpdate = new Supplierdto
                {
                    SupplierID = this.SupplierID,
                    CompanyName = this.CompanyName,
                    ContactName = this.ContactName,
                    ContactTitle = this.ContactTitle,
                    Address = this.Address,
                    City = this.City,
                    Region = this.Region,
                    PostalCode = this.PostalCode,
                    Country = this.Country,
                    Phone = this.Phone,
                    Fax = this.Fax,
                    HomePage = this.HomePage,
                    LastChanged = this.TimeStamp
                };
                dal.Update(toUpdate);
                TimeStamp = toUpdate.LastChanged;
            }
        }

        [DeleteSelf]
        private void DeleteSelf([Inject] ISupplierDAL dal)
        {
            using (BypassPropertyChecks)
            {
                Delete(this.SupplierID, dal);
            }
        }

        [Delete]
        private void Delete(int id, [Inject] ISupplierDAL dal)
        {
            dal.Delete(id);
        }
    }
}
