using DemoLinqToObject2;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
ListProduct lp=new ListProduct();
//giả lập dữ liệu
lp.gen_sample_products();
Console.WriteLine("Danh sách Products:");
lp.PrintProducts();
Console.WriteLine("Danh sách các sản phẩm có giá từ 80 tới 100");
lp.FilterProductByPrice(80, 100);

Console.WriteLine("Danh sách các sản phẩm có giá từ 200 tới 300 và sắp xếp");
lp.FilterProductsByPriceDesc(200, 300);
