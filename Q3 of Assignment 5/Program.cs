class IntegerMatrix //Q3 of Assignment 5
{
    public static void Main()
    {
        int flag = 0;
        int[,] matrix = { {1,3,5,7 },{10,11,16,20},{23,30,34,60}};
        int j = 0,p=0;
        int[] a1 = new int[5];
        int[] a2 = new int[5];
        for (int i=1; i<3;i++)
        {
            a1[j] = matrix[i, 0];
            j++;
        }
        for(int k=0;k<3-1;k++)
        {
            a2[p] = matrix[k,3];
            p++;
        }
        for(int i=0;i<a1.Length;i++)
        {
            if (a1[i] < a2[i])
            {
                flag = 0;
                break;
            }
            else
                flag = 1;
        }
        if (flag == 1)
            Console.WriteLine("true");
        else 
            Console.WriteLine("false");
    }
}
