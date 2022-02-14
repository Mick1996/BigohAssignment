class StringProblem
{
    public int CountChar(string str,char ch)
    {
        int result = 0;
        char[] ch1 = str.ToCharArray();
        for(int i=0;i<ch1.Length;i++)
        {
            if (ch1[i] == ch)
                result++;
        }
        return result;
    }
    public void Substring(string str,int start,int end)
    {
         for(int i=start;i<end;i++)
        {
            for(int j=i;j<=end;j++)
            {
                for(int k=i;k<j+1;k++)
                {
                    Console.Write(str[k]);
                }
                Console.WriteLine();
            }
        }
    }
    public void splitstring(string str,char ch)
    {
        char [] ch1=str.ToCharArray();
        for(int i=0;i<ch1.Length;i++)
        {
            if (ch1[i] == ch)
            {
                Console.WriteLine();
                continue;
            }
            else
                Console.Write(str[i]);
        } 
    }
    public bool HasPattern(string str,string pattern)
    {
        int Flag = 0;
        int len = str.Length;
        int n = pattern.Length;
        for(int i=0; i<=len-n;i++)
        {
            int k = i;
            for(int j=0;j<n;j++)
            {
                if (str[k] != pattern[j])
                {
                    Flag = 0;
                    break;
                }
                else
                {
                    Flag = 1;
                    k++;
                }
            }
            if (Flag == 1)
                return true;
        }
        return false;
    }
    public bool AllwordsContainChar(string str,char ch)
    {
        int flag= 0;
        string [] str1=str.Split(" ");
        for(int i=0;i<str1.Length;i++)
        {
            string s=str1[i];
            char [] ch1=s.ToCharArray();
            for(int j=0;j<ch1.Length;j++)
            {
                if (ch1[j] == ch)
                {
                    flag = 1;
                    break;
                }
                else
                    flag = 0;
            }
            if (flag == 0)
                return false;
        }
         return true;
    }
}
class Program
{
    public static void Main()
    {
        StringProblem p = new StringProblem();
        int charoccurence=p.CountChar("mathematics",'m');
        Console.WriteLine($"{charoccurence} times");
        Console.WriteLine("Substring are:");
        p.Substring("mathematics",1,6);
        Console.WriteLine("string splitted");
        p.splitstring("iliveinDelhicity",'i');
        Console.WriteLine("\nchecking pattern Found or not");
        bool result = p.HasPattern("bigohtech","iohte");
        Console.WriteLine(result);
        Console.WriteLine("checking all words containing given character or  not");
        bool res= p.AllwordsContainChar("ic livce inc ountry",'c');
        Console.WriteLine(res);
    }
}