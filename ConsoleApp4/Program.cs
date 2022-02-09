using System.Text.RegularExpressions; //question 4
class validUrl
{
    public bool isValid(string url)
    {
        //string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
        string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(.com)";
        Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        return Rgx.IsMatch(url);
    }
}
class Program
{
    public static void Main()
    {
        string str = "http://www.google.com";
        validUrl v = new validUrl();
        bool result=v.isValid(str);
        Console.WriteLine(result);
    }
}
