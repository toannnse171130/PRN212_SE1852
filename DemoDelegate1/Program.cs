
using System.Text;
class Program
{
    public delegate int[] MyDelegate(int n);
    static int[] ListEven(int n)
    {
        List<int> list = new List<int>();
        for (int i = 2; i <= n; i=i+2)
            list.Add(i);
        return list.ToArray();
    }
    static int[]ListPrime(int n)
    {
        List<int>list = new List<int>();
        for(int i = 2;i <= n;i++)
        {
            int count = 0;
            for(int j=1;j<=i;j++)
            {
                if(i%j==0)
                  count++;
            }    
            if(count==2)
                list.Add(i);
        }    
        return list.ToArray();
    }
   
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        MyDelegate d1 = new MyDelegate(ListEven);
        int[] result1 = d1(10);
        Console.WriteLine("danh sách các số chẵn :");
        foreach (int i in result1) 
            Console.WriteLine(i);

        d1=new MyDelegate(ListPrime);
        int[]result2=d1(10);
        Console.WriteLine("Danh sách các số nguyên tố:");
        foreach (int i in result2)
            Console.WriteLine(i);
    }
}
