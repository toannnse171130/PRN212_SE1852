using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinqToObject2
{
    public class ListProduct
    {
        List<Product> products;
        public ListProduct()
        {
            products = new List<Product>();
        }
        public void gen_sample_products()
        {
            products.Add(new Product() { Id=1,Name="P1",Quantity=10,Price=100});
            products.Add(new Product() { Id = 2, Name = "P2", Quantity = 10, Price = 100 });
            products.Add(new Product() { Id = 3, Name = "P3", Quantity = 20, Price = 300 });
            products.Add(new Product() { Id = 4, Name = "P4", Quantity = 18, Price = 200 });
            products.Add(new Product() { Id = 5, Name = "P5", Quantity = 7, Price = 150});
            products.Add(new Product() { Id = 6, Name = "P6", Quantity = 30, Price = 80 });
            products.Add(new Product() { Id = 7, Name = "P7", Quantity = 25, Price = 80 });
            products.Add(new Product() { Id = 8, Name = "P8", Quantity = 28, Price = 70 });
            products.Add(new Product() { Id = 9, Name = "P9", Quantity = 17, Price = 60});
            products.Add(new Product() { Id = 10, Name = "P10", Quantity = 10, Price = 75});
        }
        public void PrintProducts()
        {
            products.ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductByPrice(double price1,double price2)
        {
            var results=products.Where(p=>p.Price>=price1 && p.Price<=price2);
            results.ToList().ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductsByPriceDesc(double price1, double price2)
        {
            var results = from p in products
                          where p.Price >= price1 && p.Price <=price2
                          orderby p.Price descending
                          select p;
            results.ToList().ForEach(p => Console.WriteLine(p));
        }
        public void FilterProductsByQuantity(int q1,int q2)
        {
            var results = from p in products
                          where p.Quantity >= q1 && p.Quantity <= q2
                          select new { p.Id, p.Name };
           foreach (var item in results)
                Console.WriteLine(item.Id+"\t"+item.Name);
        }
    }
}
