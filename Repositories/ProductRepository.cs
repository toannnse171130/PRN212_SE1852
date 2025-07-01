using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        ProductDAO productsDAO = new ProductDAO();

        public bool DeleteProduct(int id)
        {
            return productsDAO.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return productsDAO.GetProducts();
        }
        public void InitializeDataset()
        {
           productsDAO.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return productsDAO.SaveProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return productsDAO.UpdateProduct(p);
        }
    }
}
