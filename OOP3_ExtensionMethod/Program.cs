using OOP3_ExtensionMethod;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine("Tổng n1="+ n1.TongTu1ToiN());
Console.WriteLine("Tổng n2=" + n2.TongTu1ToiN());

int[] M = new int[10];
M.TaoMangNgauNhien();
Console.WriteLine("Mảng trước khi sắp xếp:");
M.XuatMang();
M.SapXepTangDan();
Console.WriteLine("Mảng sau khi sắp xếp:");
M.XuatMang();
