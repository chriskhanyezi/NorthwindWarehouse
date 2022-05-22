using Csla;
using Northwind.DataAccess.DataAccessInterface;
using Northwind.DataAccess.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Categories
{
    [Serializable()]
    public class CategoryList : ReadOnlyListBase<CategoryList, CategoryInfo>
    {
        public void RemoveChild(int categoryId)
        {
            var iro = IsReadOnly;
            IsReadOnly = false;
            try
            {
                var item = this.Where(r => r.Id == categoryId).FirstOrDefault();
                if (item != null)
                {
                    var index = this.IndexOf(item);
                    Remove(item);
                }
            }
            finally
            {
                IsReadOnly = iro;
            }
        }

        public async static Task<CategoryList> GetCategoryListAsync()
        {
            return await Csla.DataPortal.FetchAsync<CategoryList>();
        }

        public static CategoryList GetCategoryList()
        {
            return DataPortal.Fetch<CategoryList>();
        }

        public static CategoryList GetCategoryList(string name)
        {
            return DataPortal.Fetch<CategoryList>(name);
        }

        [Fetch]
        private void Fetch([Inject] ICategoryDAL dal)
        {
            Fetch(null, dal);
        }

        [Fetch]
        private void Fetch(string name, [Inject] ICategoryDAL dal)
        {
            using (LoadListMode)
            {
                List<Categorydto> list = new List<Categorydto> { new Categorydto { CategoryID = -1, CategoryName = "Select A Category" } };
                if (name == null)
                    list.AddRange(dal.Fetch());
                else
                    list.AddRange(dal.Fetch(name));
                foreach (var item in list)
                    Add(DataPortal.FetchChild<CategoryInfo>(item));
            }
        }
    }
}
