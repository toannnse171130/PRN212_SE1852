using BusinessObjects_EntityFramework;
using Repositories_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_EntityFramework
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository repository;
        public CategoryService()
        {
            repository = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return repository.GetCategories();
        }
    }
}
