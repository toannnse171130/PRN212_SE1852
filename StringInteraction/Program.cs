
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string ho = "Nguyễn";
String tenlot = "Thị";
string ten = "Tèo";
string tenfull=ho+" "+tenlot+" "+ten;
Console.WriteLine(tenfull);
StringBuilder sb=new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
string name2 = sb.ToString();
Console.WriteLine(name2);
Console.ReadLine();