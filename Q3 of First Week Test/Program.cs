class Program
{
    public static void Main()
    {
        int[] arr = {8,5,10,7,9,4,15,12,90,13};
        int []MaxArray=new int[100];
        int k = 4,p=0,max=0;
        int c = k - 1;
        for(int i=0;i<arr.Length-c;i++)
        {
           for(int j=i;j<=i+k-1;j++)
            {
              MaxArray[p]=arr[j];
                p++;
            }
           //for getting maximum value from array
           for(int l=0;l<MaxArray.Length;l++)
            {
                if(MaxArray[l]>max)
                {
                    max = MaxArray[l];
                }
            }
            Console.Write(max+" ");
            max = 0; p=0;
            Array.Fill(MaxArray,0);
        }
    }
}