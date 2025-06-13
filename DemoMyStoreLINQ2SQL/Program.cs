using DemoMyStoreLINQ2SQL;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;;
string connectionString = "server=THANHTRAN;database=MyStore;uid=sa;pwd=123456";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Câu 1: Dùng LINQ2SQL để lấy toàn bộ Categories
var categories=context.Categories;
foreach (var cate in categories)
{
    Console.WriteLine(cate.CategoryID+"\t"+ cate.CategoryName);
}
//Câu 2:
//Tìm chi tiết 1 danh mục khi biết CategoryId
int cateid = 5;
Category category = context.Categories
                           .FirstOrDefault(c => c.CategoryID == cateid);
if (category== null)
{
    Console.WriteLine($"Không tìm thấy danh mục có mã ={cateid}");
}
else
{
    Console.WriteLine($"Tìm thấy danh mục có mã ={cateid}, chi tiết:");
    Console.WriteLine(category.CategoryID+"\t"+category.CategoryName);
}
/*//Câu 3: Thêm mới 1 danh mục
Category cnew=new Category();
cnew.CategoryName = "Hách nôi";
context.Categories.InsertOnSubmit(cnew);
context.SubmitChanges();*/

/*//câu 4: Thêm mới nhiều danh mục cùng 1 lúc
List<Category> dsdm_new = new List<Category>();
dsdm_new.Add(new Category() { CategoryName="Laptop"});
dsdm_new.Add(new Category() { CategoryName = "TV" });
dsdm_new.Add(new Category() { CategoryName = "Phụ kiện" });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();
*/

//Câu 5: Sửa tên danh mục
//nguyên tắc: Phải tìm trước=> tìm thấy mới sửa
Category c = (from x in context.Categories
             where x.CategoryID == 10
             select x).FirstOrDefault();

Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if (c2 != null)
{
    c2.CategoryName = "Hôi nách";
    context.SubmitChanges();
}    
//Câu 6: Xóa danh mục
//tìm thấy danh mục rồi mới xóa
Category c3=context.Categories.FirstOrDefault(x=>x.CategoryID == 13);
if(c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}    
//Câu 7: Xóa tất cả danh mục mà không chứa bất kỳ sản phẩm nào