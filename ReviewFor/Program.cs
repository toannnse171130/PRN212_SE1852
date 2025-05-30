using System.Text;

Console.OutputEncoding=Encoding.UTF8;
//Bước 1: ứng dụng out để kiểm tra nhập hợp lệ
//nhập khi nào đúng thì mới dừng
int n;
Console.WriteLine("Nhập n>=0:");
string s=Console.ReadLine();
if(int.TryParse(s, out n)==false)
{
    Console.WriteLine("Bạn phải nhập số");
} 
else
{
    if(n<0)
    {
        Console.WriteLine("Tui đã nói n phải >=0 mà");
    }
    else
    {
        //thực thi tính giai thừa n!
        int gt = 1;
        for (int i = 1; i <= n; i++)
            gt = gt * i;
        Console.WriteLine($"{n}!={gt}");
    }
}    