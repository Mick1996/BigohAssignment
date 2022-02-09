class Program //question 3 of assignment 2
{
    public static void Main()
    {
       
        for(int i=0;i<7;i++)
        {
           for(int j=0;j<7;j++)
            {
                if (i == j)
                    Console.Write("\\");
                else if(i+j==7-1)
                    Console.Write("\\");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}