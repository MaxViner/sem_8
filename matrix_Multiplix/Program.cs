Console.WriteLine("програма дает результат перемножения двух матриц");
Console.WriteLine("колличество столбцов матрицы 1 = колличество строк матрицы 2. строк в1  - столбцов в 2");
Console.WriteLine("колличество столбцов матрицы 1? (строк в 2)");
int Wide =  int.Parse(Console.ReadLine());
Console.WriteLine("колличество строк матрицы 1? (столбцов в 2)");
int Up =  int.Parse(Console.ReadLine());

int[,] FillArray(int Up,int Wide)
            {
            int[,] matrix1 = new int[Up,Wide];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        matrix1[i,j]= new Random().Next(-100,100);
                    }
        
                }
            return matrix1;
            }
void PrintArray(int[,] matrix1)
            {

           // Console.WriteLine("случайным образом был сгенерирован следующий массив:");
            for (int i=0;i<matrix1.GetLength(0);i++) 
                {
                    int j = 0;
                    while ( j!=(matrix1.GetLength(1)-1)) 
                    {
                        if (matrix1[i,j]<0 && (matrix1[i,j])/10==0) Console.Write( matrix1[i,j]+"  , ");
                        else if (matrix1[i,j]/10==0) Console.Write(" "+ matrix1[i,j]+"  , ");
                        else if (matrix1[i,j]<0 ) Console.Write( matrix1[i,j]+" , ");
                        else Console.Write(" "+matrix1[i,j]+" , ");
                        j++;
                    }
                    Console.WriteLine(matrix1[i,j]);
                }
            Console.WriteLine();
            }

int[,] Matrix_mult (int [,] matrix1, int [,] matrix2)
{
        int [,] multiplix = new int [Up,Up];
        for(int k=0;k<matrix1.GetLength(0);k++)
        {
            for (int t=0;t<matrix1.GetLength(0);t++)
            {
                for (int i=0;i<matrix1.GetLength(0);i++)
                {
                    multiplix[k,t] = multiplix[k,t]+ matrix1[k,i]*matrix2[i,k];
                }
            }
        }
return multiplix;
}
// try
// {
    int [,] matrix1 = new int[Up,Wide];
    int [,] matrix2 = new int[Up,Wide];
    matrix1 = FillArray(Up,Wide);

    matrix2 = FillArray(Wide,Up);

    Console.WriteLine("случайным образом были сгенерированы 2 матрицы: ");
    PrintArray(matrix1);
    PrintArray(matrix2);

    int[,] rezult = new int[Up,Up];

    Console.WriteLine("Результат перемножения будет иметь вид: ");
    rezult  = Matrix_mult (matrix1,matrix2);
    PrintArray(rezult);
// }
// catch
// {
//     Console.WriteLine("oh...somethin wrong");
// }


