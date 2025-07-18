using BusinessObjects_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_EntityFramework
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public List<Product> GetProductsByCategory(int cateid);
        public bool SaveProduct(Product product);
        public bool UpdateProduct(Product product);
        public bool DeleteProduct(int productId);
    }
}
