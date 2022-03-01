/*class Program
{
    public static void Main()
    {
        // Console.WriteLine("Enter The Total Number of Elements");
        //int n=Convert.ToInt32(Console.ReadLine());
        int[] num = {2,1,3};
        int[] Counter=new int[num.Length];
        int differ = 0;
        Array.Fill(Counter,0);
        for(int i=1;i<num.Length;i++)
        {
            for(int j=i-1;j>=0;j--) //j=1 i=2
            {
                if(num[j]<num[i])
                {
                    differ = num[i] - num[j];
                    Counter[i] = Counter[i] + differ;
                }
                else
                {
                    differ = num[j] - num[i];
                    Counter[i] = Counter[i]- differ;
                }
            }
        }
        Console.WriteLine("Result");
        foreach(var item in Counter)
        {
            Console.WriteLine(item);
        }
    }
}*/
class Program
{
    public static void Main()
    {
        int[] num = { 2, 4, 3 };
        int[] Counter = new int[num.Length];
        int differ = 0;
        Array.Fill(Counter, 0);
        for(int i=1;i<num.Length;i++)
        {
            Fun(i,i-1,num,Counter,differ);
        }
        //print Counter 
        Console.WriteLine("Result");
        foreach (var item in Counter)
        {
            Console.WriteLine(item);
        }
    }
    public static void Fun(int i,int j,int[] num,int[] Counter,int differ)
    {
        
      if(j>=0)
        {
            if (num[j] < num[i])
            {
                differ = num[i] - num[j];
                Counter[i] = Counter[i] + differ;
            }
            else
            {
                differ = num[j] - num[i];
                Counter[i] = Counter[i] - differ;
            }
            j--;
        }
        if (j >= 0)
        {
            Fun(i,j,num,Counter,differ);
        }
    }
}



