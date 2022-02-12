class Median
{
    public static void Main()
    {
        int[] num1 = {1,2,3,4,5,6,7};
        int[] num2 = {5,6,7,8,9,10,11,12};
         int len1=num1.Length;
         int len2=num2.Length;
        int len3 = len1 + len2;
        int [] ar3=new int[len3];
        int i = 0, j = 0, k = 0;
        while (i < len1 && j < len2)
        {
            if (num1[i] < num2[j])
            {
                ar3[k] = num1[i];
                k++; i++;
            }
            else
            {
                ar3[k] = num2[j];
                k++; j++;
            }
        }
        while(i<len1)
        {
            ar3[k] = num1[i];
            k++; i++;
        }
        while (j < len2)
        {
            ar3[k] = num2[j];
            k++; j++;
        }
        int len4=ar3.Length;
        int mid = len4 / 2;
        if(len4%2==0) //if your data's length is even
        {
            double median = ar3[mid] + ar3[mid - 1] / 2.0;
            Console.WriteLine($"Median:{median}");
        }
        else
        {
            Console.WriteLine($"Median:{ar3[mid]}");
        }
    }
}