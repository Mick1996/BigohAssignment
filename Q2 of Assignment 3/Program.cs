class KingSafe   //q2 of assignment 3
{
    public bool isKingSafe(string[,] chessBoard)
    {  
        for(int i=0;i<5;i++)
        {
            for(int j=0;j<5;j++)
            {
                if(chessBoard[i,j]=="elephant")
                {
                   for(int k=0;k<5;k++)
                    {
                        if (chessBoard[i, k] == "king")
                            return false;
                         if (chessBoard[k, j] == "king")
                            return false;
                    }
                }
                if(chessBoard[i,j]=="camel")
                {
                    int col = j - 1,col1=j; //1
                    if (col < 0)//if camel at 0 colonm then dont go down
                    {
                        for (int k = i + 1; k < 5; k++) //checking down /
                        {
                            if (chessBoard[k, col] == "king")//3 1
                            {
                                return false;
                            }
                            col--;
                        }
                    }
                          col1++;
                        for (int k = i-1; k >= 0; k--) //checking up /
                        {
                            if (chessBoard[k, col1] == "king")
                            {    
                                return false;
                            }
                            col1++;
                               if (col1 > 4)
                                  break;
                        }
                    
                        int col3=j+1;
                        for (int l = i+1; l < 5; l++) //row   \ right down
                        {
                           if(chessBoard[l,col3]=="king")
                            {
                                return false;
                            }
                              col3++;
                           if (col3 > 4)
                            break;
                        }
                           int c1 = j-1;
                         for(int l=i-1;l>=0;l--) //  / left down 
                        {
                            if (c1 < 0)
                               break;
                        if (chessBoard[l, c1] == "king")
                            {
                                return false;
                            }
                            c1--;
                        
                        }

                }
                 if(chessBoard[i,j]=="queen")
                {
                    int row = i, cols = j;
                    row = row + 2;
                    cols++;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    cols = cols - 2;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    //above code making l below
                    row = i; cols = j;
                    row = row - 2;
                    cols++;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    cols = cols - 2;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    //above code making l up side
                    row = i; cols = j;
                    cols = cols + 2;
                    row--;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    row = row - 2;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    //above code making l right side
                    row = i; cols = j;
                    cols = cols - 2;
                    row++;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    row = row + 2;
                    if (chessBoard[row, cols] == "king")
                        return false;
                    //above code making l left side
                    row = i; cols = j;
                //above code work as horse
                          
                    for (int k=0;k<5;k++)
                  {
                      if (chessBoard[i, k] == "king")
                          return false;
                       if (chessBoard[k, j] == "king")
                          return false;
                  }
                    //work as camel
                    int col = j - 1, col1 = j; //1
                    if (col < 0)//if camel at 0 colonm then dont go down
                    {
                        for (int k = i + 1; k < 5; k++) //checking down /
                        {
                            if (chessBoard[k, col] == "king")//3 1
                            {
                                return false;
                            }
                            col--;
                        }
                    }
                    col1++;
                    for (int k = i - 1; k >= 0; k--) //checking up /
                    {
                        if (chessBoard[k, col1] == "king")
                        {
                            return false;
                        }
                        col1++;
                        if (col1 > 4)
                            break;
                    }

                    int col3 = j + 1;
                    for (int l = i + 1; l < 5; l++) //row   \ right down
                    {
                        if (chessBoard[l, col3] == "king")
                        {
                            return false;
                        }
                        col3++;
                        if (col3 > 4)
                            break;
                    }
                    int c1 = j - 1;
                    for (int l = i - 1; l >= 0; l--) //  / left down 
                    {
                        if (c1 < 0)
                            break;
                        if (chessBoard[l, c1] == "king")
                        {
                            return false;
                        }
                        c1--;

                    }
                }
                  if(chessBoard[i,j]=="horse") //horse part
                 {
                     int row = i, col = j;
                         row = row + 2;
                       col++;
                     if (chessBoard[row, col] == "king")
                         return false;
                     col = col - 2;
                     if (chessBoard[row, col] == "king")
                         return false;
                      //above code making l below
                     row = i; col = j;
                         row = row - 2;
                     col++;
                     if (chessBoard[row, col] == "king")
                         return false;
                     col = col - 2;
                     if (chessBoard[row, col] == "king")
                         return false;
                     //above code making l up side
                     row = i;col = j;
                     col= col +2;
                     row--;
                     if (chessBoard[row, col] == "king")
                         return false;
                     row = row - 2;
                     if (chessBoard[row, col] == "king")
                         return false;
                     //above code making l right side
                     row=i; col = j;
                     col = col - 2;
                     row++;
                     if (chessBoard[row, col] == "king")
                         return false;
                     row = row + 2;
                     if (chessBoard[row, col] == "king")
                         return false;
                     //above code making l left side
                     row = i;col = j;
                 } 
            }
        }
        return true;
    }
}
class Chess
{
    public static void Main()
    {
        string[,] chessBoard = new string[5,5];
        Console.WriteLine("Enter the Position of King");
        int kr=Convert.ToInt32(Console.ReadLine());
        int kc=Convert.ToInt32(Console.ReadLine());
        chessBoard[kr, kc] = "king";
        Console.WriteLine("Enter The Position of Elephant");
        int er=Convert.ToInt32(Console.ReadLine());
        int ec=Convert.ToInt32(Console.ReadLine());
        chessBoard[er,ec]= "elephant";
        Console.WriteLine("Enter The Position of Horse");
        int hr = Convert.ToInt32(Console.ReadLine());
        int hc = Convert.ToInt32(Console.ReadLine());
        chessBoard[hr, hc] = "Horse";
        Console.WriteLine("Enter The Position of Camel");
        int cr = Convert.ToInt32(Console.ReadLine());
        int cc = Convert.ToInt32(Console.ReadLine());
        chessBoard[cr, cc] = "camel";
        Console.WriteLine("Enter The Position of Queen");
        int qr = Convert.ToInt32(Console.ReadLine());
        int qc = Convert.ToInt32(Console.ReadLine());
        chessBoard[qr, qc] = "queen";
        KingSafe k=new KingSafe();
        bool Result=k.isKingSafe(chessBoard);
        Console.WriteLine(Result);
    }
}