public class LengthLongestSubstr //Q2 0f Assignment 4
{ 
	  public static void Main()
	{
		string s = "abcabcbb";
		int len = s.Length;
		int result = 0;
		int[] arr = new int[256]; //ascii value of every character is less than 256 
		Array.Fill(arr, -1); //fill -1 at all position of array 
		int i = 0;
		for (int k = 0; k < len; k++)
		{
			i = Math.Max(i, arr[s[k]] + 1); //fetch value from ascii code then add 1.
			result = Math.Max(result, k - i + 1);//hold longest substring length.
			arr[s[k]] = k;      //transfering index of last character if character is repeating then increase i value.
		}
		Console.WriteLine(result);
	}
}
