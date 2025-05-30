/*
 * Ứng dụng Generic để quản lý nhân viên, thực hiện
 * các thao tác CRUD
 * C- Create -> Thêm mới
 * R- Read (Retrieve) --> truy vấn: Xem, sắp xếp, lọc...
 * U- Update -> Chỉnh sửa dữ liệu
 * D- Delete -> Xóa dữ liệu
 */
//Câu 1: Tạo 5 nhân viên, 4 fulltime, 1 parttime
using OOP2;
using System.Text;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name 1",
    IdCard = "123",
    Birthday = new DateTime(1980, 1, 1)
};
employees.Add(fe1);

FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name 2",
    IdCard = "456",
    Birthday = new DateTime(1982, 12, 13)
};
employees.Add(fe2);

FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name 3",
    IdCard = "789",
    Birthday = new DateTime(1990, 11, 21)
};
employees.Add(fe3);

FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name 4",
    IdCard = "321",
    Birthday = new DateTime(1993, 9, 27)
};
employees.Add(fe4);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 5,
    Name = "Name 5",
    IdCard = "987",
    WorkingHour =3,
    Birthday = new DateTime(1995, 2, 2)
};
employees.Add(pe1);

//Câu 2: Xuất toàn bộ thông tin nhân sự (R)
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Thông tin toàn bộ nhân sự:");
//cách 1: Dùng Expression body (Lambda Expression)
employees.ForEach(e => Console.WriteLine(e));
//Cách 2: Dùng for thông thường (ko dùng =>)
Console.WriteLine("------Cách for thông thường------");
foreach(var e in employees)
{
    Console.WriteLine(e);
}    
//Câu 3: Sắp xếp nhân viên theo năm sinh tăng dần
//cũng là R-Read/Retrieve
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Employee ei=employees[i];
        Employee ej=employees[j];
        if(ei.Birthday<ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }    
    }           
}
Console.WriteLine("---------Employees sau khi sắp xếp:");
employees.ForEach(e => Console.WriteLine(e));