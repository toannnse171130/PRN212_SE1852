using LucyDemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "server=THANHTRAN;database=Lucy_SalesData;uid=sa;pwd=123456";

Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//Câu 1: Xuất danh sách khách hàng có mua hàng
var ds1 = from c in context.Customers
          where c.Orders.Count() > 0
          select c;
Console.WriteLine("Danh sách khách hàng có mua hàng:");
foreach(var c in ds1)
{
    Console.WriteLine(c.CustomerID+"\t"+c.ContactName);
}
//Câu 2: Lọc ra 3 khách hàng mua hàng nhiều nhất cho Công ty
//từ đó để ra chính sách nâng khách hàng VIP
