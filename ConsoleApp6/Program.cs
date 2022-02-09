class uniqueArray //question 1 of assignment 2
{
    public int[] removeDuplicates(int [] values)
    {
        int[] arr = new int[values.Length];
     for(int i=0;i<values.Length;i++)
        {
            if (values[i] != -1)
            {
                int n = values[i];
                for (int j = i + 1; j < values.Length; j++)
                {

                    if (n == values[j])
                        values[j] = -1;
                }
            }
        }
         for(int i=0;i<values.Length;i++)
        {
            if(values[i]!=-1)
            {
              arr[i]=values[i];
            }
        }
          return arr;
    }
}
class Program
{
    public static void Main()
    {
        int[] arr = {1,2,5,4,8,9,5,4,2,7};
        uniqueArray u = new uniqueArray();
        int[] resultArray=u.removeDuplicates(arr);
        for(int i=0;i<resultArray.Length;i++)
        {
            if(resultArray[i]!=0)
            Console.WriteLine(resultArray[i]);
        }
    }
}