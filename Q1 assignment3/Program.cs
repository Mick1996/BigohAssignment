class Suduko //question 1 of assignment 3
{
    public bool isValidSuduko(int[,] arr)
    {
        int value = 0;
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                value = arr[i,j];
                 for(int k=0;k<3;k++)
                {
                    for(int l=0;l<3;l++)
                    {
                        if (i == k && j == l)
                            break;
                        if (i == k || j == l)
                        {
                            if (value == arr[k, l])
                            {
                                return false;
                            }
                        }
                    }
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
        //int[,] arr = { { 9, 2, 1, 5,4, 3, 8, 6}, {4,3,8,2,7,1,5,9}, {5,1,3,9,6,7,2,4}, {6,5,9,7,3,8,4,1}, {8,9,5,6,1,2,7,3}, {1,7,4,8,2,9,6,5}, {3,6,7,4,8,5,9,2}, {7,4,2,1,5,6,3,8 }, {2,8,6,3,9,4,1,7 } };
        int[,] arr = { {1,2,4 },{6,5,8 },{3,7,9}};
        Suduko su=new Suduko();
        bool result=su.isValidSuduko(arr);
        Console.WriteLine(result);
    }
}