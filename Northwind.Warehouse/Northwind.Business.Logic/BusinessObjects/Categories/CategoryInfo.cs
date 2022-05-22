using Csla;
using Northwind.DataAccess.DataObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace Northwind.Business.Logic.Categories
{
    [Serializable()]
    public class CategoryInfo : ReadOnlyBase<CategoryInfo>
    {
        public static readonly PropertyInfo<int> IdProperty = RegisterProperty<int>(c => c.Id);
        [Display(Name = "Category id")]
        public int Id
        {
            get { return GetProperty(IdProperty); }
            private set { LoadProperty(IdProperty, value); }
        }

        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(c => c.Name);
        [Display(Name = "Category name")]
        public string Name
        {
            get { return GetProperty(NameProperty); }
            private set { LoadProperty(NameProperty, value); }
        }

        public void SetName(CategoryEdit item)
        {
            Name = item.CategoryName;
            OnPropertyChanged(NameProperty);
        }

        public override string ToString()
        {
            return Name;
        }

        [FetchChild]
        private void Fetch(Categorydto item)
        {
            Id = item.CategoryID;
            Name = item.CategoryName;
        }
    }
}
