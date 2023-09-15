
int row, i, j;

Console.Write("Enter the number of rows: ");
row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");

            
    for (i = 1; i <= row; i++)
        {
             
          for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
             
                Console.WriteLine("");
         
        }