using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void InitializeDataset()
        {
            products.Add(new Product() { Id=1,Name="Coca",Quantity=10,Price=200});
            products.Add(new Product() { Id = 2, Name = "Pepsi", Quantity = 8, Price = 100 });
            products.Add(new Product() { Id = 3, Name = "Sting", Quantity = 20, Price = 250 });
            products.Add(new Product() { Id = 4, Name = "Aqua", Quantity = 17, Price = 70 });
            products.Add(new Product() { Id = 5, Name = "Redbull", Quantity = 15, Price = 250 });

        }
        public List<Product> GetProducts() { 
            return products;
        }
        public bool SaveProduct(Product p)
        {
            Product old=products.FirstOrDefault(x=>x.Id==p.Id);
            if (old != null)
                return false;//thêm mới thất bại vì trùng mã sản phẩm
            products.Add(p);//thêm mới thành công
            return true;
        }
        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old == null)
                return false;//sửa thất bại vì ko tìm thấy mã sản phẩm
            old.Name = p.Name;
            old.Quantity = p.Quantity;
            old.Price = p.Price;
            return true;
        }
        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.Id == id);
            if (old == null)
                return false;//xóa thất bại vì ko tìm thấy mã sản phẩm
            products.Remove(old);
            return true;
        }
    }
}
