//Câu 1: Vẽ hình
void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if(j==0 ||  j==n-1 || i==j)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }    
        }
        Console.WriteLine();
    }
}
//hinh1(10);
//Câu 2: Sắp xếp mảng tăng dần dùng do while
//lồng nhau
void swap(ref int a, ref int b)
{
    int temp=a; 
    a=b; 
    b=temp;
}
void mysort(int[]arr)
{
    int i = 0;
    int j = i+1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }while(j<arr.Length-1);        
        i++;
        j = i + 1;
    } while (i<arr.Length-1);
}
int[] arr = { 10, 3, 7, 2, 9 };
Console.WriteLine("Mảng trước khi sắp xếp:");
foreach (int x in arr)
    Console.Write($"{x}\t");
Console.WriteLine();
mysort(arr);
Console.WriteLine("Mảng sau khi sắp xếp:");
foreach (int x in arr)
    Console.Write($"{x}\t");
