using Csla;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using Northwind.Infrastructure.Security;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Categories
{
    [Serializable()]
    public class CategoryEdit : Infrastructure.CslaBaseTypes.BusinessBase<CategoryEdit>
    {
        public static readonly PropertyInfo<byte[]> TimeStampProperty = RegisterProperty<byte[]>(c => c.TimeStamp);
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public byte[] TimeStamp
        {
            get { return GetProperty(TimeStampProperty); }
            set { SetProperty(TimeStampProperty, value); }
        }

        public static readonly PropertyInfo<int> CategoryIDProperty = RegisterProperty<int>(c => c.CategoryID);
        [Display(Name = "Category ID")]
        public int CategoryID
        {
            get { return GetProperty(CategoryIDProperty); }
            set { SetProperty(CategoryIDProperty, value); }
        }

        public static readonly PropertyInfo<string> CategoryNameProperty = RegisterProperty<string>(c => c.CategoryName);
        [Display(Name = "Category Name")]
        [Required]
        [StringLength(15)]
        public string CategoryName
        {
            get { return GetProperty(CategoryNameProperty); }
            set { SetProperty(CategoryNameProperty, value); }
        }

        public static readonly PropertyInfo<string> DescriptionProperty = RegisterProperty<string>(c => c.Description);
        [Display(Name = "Description")]
        public string Description
        {
            get { return GetProperty(DescriptionProperty); }
            set { SetProperty(DescriptionProperty, value); }
        }

        public static readonly PropertyInfo<byte[]> PictureProperty = RegisterProperty<byte[]>(c => c.Picture);
        public byte[] Picture
        {
            get { return GetProperty(PictureProperty); }
            set { SetProperty(PictureProperty, value); }
        }

        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, CategoryNameProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, DescriptionProperty, Roles.WarehouseManager));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.WriteProperty, PictureProperty, Roles.WarehouseManager));
        }

        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [ObjectAuthorizationRules]
        public static void AddObjectAuthorizationRules()
        {
            Csla.Rules.BusinessRules.AddRule(typeof(CategoryEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.CreateObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(CategoryEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.EditObject, Roles.WarehouseManager));
            Csla.Rules.BusinessRules.AddRule(typeof(CategoryEdit), new Csla.Rules.CommonRules.IsInRole(Csla.Rules.AuthorizationActions.DeleteObject, Roles.WarehouseManager));
        }

        public static async Task<CategoryEdit> NewCategoryEditAsync()
        {
            return await DataPortal.CreateAsync<CategoryEdit>();
        }

        public static async Task<CategoryEdit> GetCategoryEditAsync(int id)
        {
            return await DataPortal.FetchAsync<CategoryEdit>(id);
        }

        public static async Task<bool> ExistsAsync(int id)
        {
            CategoryExistsCommand cmd = await DataPortal.CreateAsync<CategoryExistsCommand>(id);
            cmd = await DataPortal.ExecuteAsync(cmd);
            return cmd.CategoryExists;
        }

        public static CategoryEdit NewCategoryEdit()
        {
            return DataPortal.Create<CategoryEdit>();
        }

        public static CategoryEdit GetCategoryEdit(int id)
        {
            return DataPortal.Fetch<CategoryEdit>(id);
        }

        public static void DeleteCategoryEdit(int id)
        {
            DataPortal.Delete<CategoryEdit>(id);
        }

        public static async Task DeleteCategoryEditAsync(int id)
        {
            await DataPortal.DeleteAsync<CategoryEdit>(id);
        }

        [RunLocal]
        [Create]
        private void Create()
        {
            BusinessRules.CheckRules();
        }

        [Fetch]
        private void Fetch(int id, [Inject] ICategoryDAL dal)
        {
            var data = dal.Fetch(id);
            using (BypassPropertyChecks)
            {
                CategoryID = data.CategoryID;
                CategoryName = data.CategoryName;
                Description = data.Description;
                Picture = data.Picture;
                TimeStamp = data.LastChanged;
            }
        }

        [Insert]
        private void Insert([Inject] ICategoryDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toInsert = new Categorydto
                {
                    CategoryName = this.CategoryName,
                    Description = this.Description,
                    Picture = this.Picture
                };
                dal.Insert(toInsert);
                CategoryID = toInsert.CategoryID;
                TimeStamp = toInsert.LastChanged;
            }
            FieldManager.UpdateChildren(this);
        }

        [Update]
        private void Update([Inject] ICategoryDAL dal)
        {
            using (BypassPropertyChecks)
            {
                var toUpdate = new Categorydto
                {
                    CategoryID = this.CategoryID,
                    CategoryName = this.CategoryName,
                    Description = this.Description,
                    Picture = this.Picture,
                    LastChanged = this.TimeStamp
                };
                dal.Update(toUpdate);
                TimeStamp = toUpdate.LastChanged;
            }
        }

        [DeleteSelf]
        private void DeleteSelf([Inject] ICategoryDAL dal)
        {
            using (BypassPropertyChecks)
            {
                Delete(this.CategoryID, dal);
            }
        }

        [Delete]
        private void Delete(int id, [Inject] ICategoryDAL dal)
        {
            dal.Delete(id);
        }
    }
}
