void doicho(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("a trong hàm ="+a);
    Console.WriteLine("b trong hàm =" + b);
}
int a=5;
int b = 7;
Console.WriteLine("a trước khi vào hàm ="+a);
Console.WriteLine("b trước khi vào hàm =" + b);
doicho(ref a,ref b);
Console.WriteLine("a sau khi vào hàm =" + a);
Console.WriteLine("b sau khi vào hàm =" + b);
Console.ReadLine();