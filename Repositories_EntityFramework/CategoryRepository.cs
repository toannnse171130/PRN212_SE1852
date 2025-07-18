using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_EntityFramework
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO=new CategoryDAO();
        public List<Category> GetCategories()
        {
            return categoryDAO.GetCategories();
        }
    }
}
