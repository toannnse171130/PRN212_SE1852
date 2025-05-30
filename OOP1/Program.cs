using OOP1;
using System.Security.Cryptography;
using System.Text;

Category c1=new Category();
c1.Id = 1;
c1.Name = "Nước mắm";
Console.OutputEncoding=Encoding.UTF8;
c1.PrintInfor();

Employee emp1=new Employee();
/*emp1._id = 1;
emp1._name = "Tèo";*/
//để thay đổi giá trị của thuộc tính:
emp1.Id = 1;//tự gọi set cho property Id
emp1.Name = "Tèo";
emp1.Phone = "113";
emp1.Email = "teo@gmail.com";
//Để lấy giá trị của thuộc tính:
//tự gọi get cho property Id
Console.WriteLine($"Employee ID={emp1.Id}");
//tự gọi get cho property Name
Console.WriteLine($"Employee Name={emp1.Name}");
//Hoặc chúng ta gọi hàm:
emp1.PrintInfor();

//Ngoài ra mọi lớp đối tượng có hàm toString() giống Java
//để tự động triệu gọi hàm này khi đối tượng được 
//xuất ra màn hình
Console.WriteLine("------------------");
Console.WriteLine(emp1);//tự gọi hàm tostring()

//Vừa tạo đối tượng vừa khởi tạo giá trị cho thuộc tính:
Employee employee2=new Employee(2,"Tý Đại Bàng","ty@yahoo.com","0981234567");
//xuất thông tin của emp2
Console.WriteLine(employee2);
//Hoặc ta có thể coding như sau:

Employee emp3 = new Employee()
{
    Id = 1,
    Name = "Tủn",
    Email = "tun@hotmail.com",
    Phone = "094364663"
};
//xuất thông tin của emp3:
Console.WriteLine(emp3); 