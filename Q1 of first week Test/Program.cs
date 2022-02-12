class InterLeavingStrings
{
	public void InterLeaving(string s1, int i, string s2, int j, string Value)
	{
		if (i == s1.Length && j == s2.Length)
		{
			Console.WriteLine(Value);
		}

		if (i < s1.Length)
			InterLeaving(s1, i + 1, s2, j, Value + s1[i]);

		if (j < s2.Length)
			InterLeaving(s1, i, s2, j + 1, Value + s2[j]);

	}
	public static void Main()
	{

		string s1 = "AB"; 
		string s2 = "CD";
		InterLeavingStrings obj=new InterLeavingStrings();
		obj.InterLeaving(s1, 0, s2, 0, "");
	}
}
