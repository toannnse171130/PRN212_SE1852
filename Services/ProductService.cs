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
    }
}
