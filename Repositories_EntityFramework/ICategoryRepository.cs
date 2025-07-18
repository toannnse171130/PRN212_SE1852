using BusinessObjects_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_EntityFramework
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}
