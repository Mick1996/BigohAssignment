class ClockWise
{
    public void clockwisePrint(int m,int n,int[,] a)
    {
        int i, k = 0, l = 0;
        while(k<m && l<n)
        {
            for(i=l;i<n;i++)
            {
                Console.Write(a[k, i] + " ");
            }
            k++;
            for(i=k;i<m;i++)
            {
                Console.Write(a[i,n-1]+" ");
            }
            n--;
            if(k<m)
            {
                for(i=n-1;i>=1;--i)
                {
                    Console.Write(a[m-1,i]+" ");
                }
                m--;
            }
            if(l<n)
            {
                for(i=m-1;i>=k;--i)
                {
                    Console.Write(a[i,l]+" ");
                }
                l++;
            }
        }
    }
    public void AntiClockWise(int m,int n,int[,]a)
    {
        int i = 0; ;
        int j = 0;
        for(j=n-1;j>=0;j--)
        {
            Console.Write(a[i,j]+" ");
        }
        j = 0;
        for(i=1;i<=m-1;i++)
        {
            Console.Write(a[i,j]+" ");
        }
        i = i - 1;
        for(j=1;j<=n-1;j++)
        {
            Console.Write(a[i,j]+" ");
        }
        i=i - 1;
        for(j=n-1;j>0;j--)
        {
            Console.Write(a[i,j]+" ");
        }
    }
}
public class Program
{
    public static void Main()
    {
        int r = 3;
        int c = 3;
        int[,] a = { { 1,2,3},{4,5,6},{7,9,40}};
        ClockWise obj = new ClockWise();
        Console.WriteLine("ClockWise or Spiral Rotation");
        obj.clockwisePrint(r,c,a);
        Console.WriteLine("AntiClockWise");
        obj.AntiClockWise(r,c,a);
    }
}