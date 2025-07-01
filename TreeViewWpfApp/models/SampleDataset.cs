using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWpfApp.models
{
    public class SampleDataset
    {
        public static Dictionary<int,Category> GenerateDataset()
        {
            Dictionary<int,Category>categories= 
                                new Dictionary<int,Category>();
            Category c1 = new Category();
            c1.Id= 1;
            c1.Name = "Laptop";

            Category c2=new Category();
            c2.Id = 2;
            c2.Name = "Tivi";

            Category c3=new Category();
            c3.Id = 3;
            c3.Name = "Phụ kiện";
            
            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            //tạo sản phẩm cho các danh mục:
            Product p1= new Product() { Id=1,Name="Dell 1",Quantity=10,Price=15};
            c1.Products.Add(p1.Id,p1);
            Product p2 = new Product() { Id = 2, Name = "Dell 2", Quantity = 5, Price = 25 };
            c1.Products.Add(p2.Id, p2);
            Product p3 = new Product() { Id = 3, Name = "HP 1", Quantity = 20, Price = 17 };
            c1.Products.Add(p3.Id, p3);
            Product p4 = new Product() { Id = 4, Name = "HP 2", Quantity = 15, Price = 30 };
            c1.Products.Add(p4.Id, p4);
            Product p5 = new Product() { Id = 5, Name = "MAC 1", Quantity = 8, Price = 22 };
            c1.Products.Add(p5.Id, p5);

            Product p6 = new Product() { Id = 6, Name = "Samsung 1", Quantity = 3, Price = 20 };
            c2.Products.Add(p6.Id, p6);
            Product p7 = new Product() { Id = 7, Name = "Samsung 2", Quantity = 4, Price = 30 };
            c2.Products.Add(p7.Id, p7);
            Product p8 = new Product() { Id = 8, Name = "LG 1", Quantity = 8, Price = 35 };
            c2.Products.Add(p8.Id, p8);
            Product p9 = new Product() { Id = 9, Name = "LG 2", Quantity = 2, Price = 17 };
            c2.Products.Add(p9.Id, p9);
            Product p10 = new Product() { Id = 10, Name = "Toshiba 1", Quantity = 7, Price = 25 };
            c2.Products.Add(p10.Id, p10);

            Product p11 = new Product() { Id = 11, Name = "Remote TQ 1", Quantity = 10, Price = 28 };
            c3.Products.Add(p11.Id, p11);
            Product p12 = new Product() { Id = 12, Name = "Remote TQ 2", Quantity = 15, Price = 25 };
            c3.Products.Add(p12.Id, p12);
            Product p13 = new Product() { Id = 13, Name = "Cục Sạc Campuchia 1", Quantity =20, Price = 17 };
            c3.Products.Add(p13.Id, p13);
            Product p14 = new Product() { Id = 14, Name = "Cục Sạc Campuchia  2", Quantity = 18, Price = 22 };
            c3.Products.Add(p14.Id, p14);
            Product p15 = new Product() { Id = 15, Name = "Mouse pad 1", Quantity = 7, Price = 9 };
            c3.Products.Add(p15.Id, p15);

            return categories;
        }
    }
}
