using System; //question 2
class SwapFirstLastDigit
{
    public static void Main()
    {
        int num, lastdigit, firstdigit, t,count = 0;
        double swap;
        Console.Write("Enter any number: ");
        num = Convert.ToInt32(Console.ReadLine());

        t = num;
        lastdigit = t % 10; //giving you last digit
        count = (int)Math.Log10(t);//count will hold total digit-1
        while (t >= 10) //while loop will give you first digit
        {
            t /= 10;
        }
        firstdigit = t;
        swap = (lastdigit * Math.Pow(10, count) + firstdigit) + (num - (firstdigit * Math.Pow(10, count) + lastdigit));

        Console.WriteLine(num + " is swapped to " + swap);
    }
}
