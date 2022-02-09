class Triplet //question 2 of Assignment 2
{
    public void GetTriplet(int [] arr,int n,int sum)
    {
        int count = 0;
       for(int i=0;i<n-2;i++)
        {
            for(int j=i+1;j<n-1;j++)
            {
                for(int k=j+i;k<n;k++)
                {
                    if(arr[i]+arr[j]+arr[k]==sum)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]} {arr[k]}");
                        count++;
                    }
                }
            }
        }
       if(count<1)
        {
            Console.WriteLine("no triplet found");
        }
    }
     
}
class Program
{
     public static void Main()
    {
        int target = 102;
        int[] arr = {1,2,3,4,5,6,7,9 };
        int n = arr.Length;
        Triplet t=new Triplet();
        t.GetTriplet(arr,n,target);
    }
}
