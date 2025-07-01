using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository iproductRepository;
        public ProductService()
        {
            iproductRepository = new ProductRepository();
        }

        public bool DeleteProduct(int id)
        {
           return iproductRepository.DeleteProduct(id);
        }

        public List<Product> GetProducts()
        {
            return iproductRepository.GetProducts();
        }

        public void InitializeDataset()
        {
            iproductRepository.InitializeDataset();
        }

        public bool SaveProduct(Product p)
        {
            return iproductRepository.SaveProduct(p);
        }

        public bool UpdateProduct(Product p)
        {
            return iproductRepository.UpdateProduct(p);
        }
    }
}
