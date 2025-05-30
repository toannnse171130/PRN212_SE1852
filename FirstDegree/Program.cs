// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("Phương Trình Bậc 1");
Console.WriteLine("Nhập hệ số a:");
double a=double.Parse(Console.ReadLine());
Console.WriteLine("Nhập hệ số b:");
double b=double.Parse(Console.ReadLine());
if (a==0 && b==0)
{
    Console.WriteLine("Phương trình vô số nghiệm");
}
else if (a==0 && b!=0)
{
    Console.WriteLine("Phương trình vô nghiệm");
}    
else
{
    Console.WriteLine("X={0}", -b / a);
}
Console.ReadLine();