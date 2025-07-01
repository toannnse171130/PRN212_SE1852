using BusinessObjects_EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_EF
{
    public class CategoryDAO
    {
        public List<Category> GetCategories()
        {
            MyStoreContext context = new MyStoreContext();  
            return context.Categories.ToList();
        }
    }
}
