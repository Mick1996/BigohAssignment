using System; //question1
public class ValidName
{
    static int count, count1;
    public bool isValidName(string Name)
    {
        int index1 = 0, index2 = 0;
        char[] name = Name.ToCharArray();
        for (int i = 0; i < name.Length; i++) //for getting first occurence of S
        {
            if (name[i] == 'S')
            {
                index1 = i;
                count1++;
                break;
            }
        }
        for (int i = name.Length-1; i > 0; i--) //for getting last occurence of S
        {
            if (name[i] == 'S')
            {
                index2 = i;
                count1++;
                break;
            }
        }
        
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
            {
                count++;
            }
            if (count > 1)
                return false;
            if (count1 == 2)
            {
                for (int j = index1; j<=index2; j++)
                {
                    if (name[j] == 'T')
                        return false;
                }
            }

        }
        return true;
    }
}

class Program
{
    public static void Main()
    {
        ValidName V = new ValidName();
        bool result = V.isValidName("hfdSRRTRTejgTS");
        Console.WriteLine(result);
    }
}








