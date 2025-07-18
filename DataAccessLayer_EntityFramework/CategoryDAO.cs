using BusinessObjects_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_EntityFramework
{
    public class CategoryDAO
    {
        MyStoreContext context = new MyStoreContext();
        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }
    }
}
