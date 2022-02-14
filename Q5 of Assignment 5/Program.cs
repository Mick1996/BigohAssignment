class Rotate90DegreeMatrix //Q5 of Assignment 5
{
    public static void Main()
    {
        int[,] matrix = {{1,2,3},{4,5,6},{7,8,9}};
        int[,] newMatrix = new int[3,3];
        int k = 0, l = 0;
        for(int j=0;j<3;j++)
        {
            for (int i = 2; i >= 0; i--)
            {
                newMatrix[k, l] = matrix[i, j];
                l++;
            }
            l=0;k++;  
        }
        Console.WriteLine("matrix rotated by 90 degree");
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<3;j++)
            {
                Console.Write(newMatrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

