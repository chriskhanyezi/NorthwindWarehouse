using Csla;
using Northwind.DataAccess.DataAccessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Logic.Categories
{
    [Serializable()]
    public class CategoryExistsCommand : CommandBase<CategoryExistsCommand>
    {
        public CategoryExistsCommand()
        { }

        public CategoryExistsCommand(int id)
        {
            CategoryID = id;
        }

        public static readonly PropertyInfo<int> CategoryIDProperty = RegisterProperty<int>(c => c.CategoryID);
        public int CategoryID
        {
            get { return ReadProperty(CategoryIDProperty); }
            private set { LoadProperty(CategoryIDProperty, value); }
        }

        public static readonly PropertyInfo<bool> CategoryExistsProperty = RegisterProperty<bool>(c => c.CategoryExists);
        public bool CategoryExists
        {
            get { return ReadProperty(CategoryExistsProperty); }
            private set { LoadProperty(CategoryExistsProperty, value); }
        }

        [Execute]
        private void Execute([Inject] ICategoryDAL dal)
        {
            CategoryExists = dal.Exists(CategoryID);
        }
    }
}
