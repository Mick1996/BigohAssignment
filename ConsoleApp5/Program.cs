class Program //question 5
{
    public static void Main()
    {
        long fact = 1;
        for(long k=1;k<=9;k++)
        {
            fact = fact * k;
        }
        int flag = 0;
        long temp=0;
        for(long i=10;i<=fact;i++)
        {
            for(long j=1;j<=9;j++)
            {
                if (i % j != 0)
                {
                    flag = 0;
                    break;
                }
                else
                {
                    temp = i;
                    flag = 1;
                }
            }
            if (flag == 1)
                break;
        }
        Console.WriteLine(temp);
    }
}