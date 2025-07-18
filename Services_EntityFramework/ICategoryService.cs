using BusinessObjects_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_EntityFramework
{
    public interface ICategoryService
    {
        public List<Category> GetCategories();
    }
}
