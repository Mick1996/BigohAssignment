using System; //question 3
class LargestPrime
{
    public void getLargestPrime(int num)
    {
     for(int i=num-1;i>0;i--)
        {
            int k=checkEveryDigitPrime(i);
            if(k!=0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
    public int checkEveryDigitPrime(int n)
    {
       int rem;
      while(n>0)
        {
            rem = n % 10;
            for(int i=2;i<rem/2;i++)
            {
                if (rem % i == 0)
                {
                     return 0;
                }    
            }
            n = n / 10;
        }
            return 1;
    }
}
class Program
{
    public static void Main()
    {
        LargestPrime l = new LargestPrime();
        l.getLargestPrime(5689);
    }
}










