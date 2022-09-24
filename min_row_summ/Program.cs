Console.WriteLine("колличество столбцов?");
int Wide =  int.Parse(Console.ReadLine());

Console.WriteLine("колличество строк?");
int Up =  int.Parse(Console.ReadLine());

int[,] FillArray(int Up,int Wide)
            {
            int[,] mas = new int[Up,Wide];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        mas[i,j]= new Random().Next(-100,100);
                    }
        
                }
            return mas;
            }
void PrintArray(int[,] mas)
            {

           // Console.WriteLine("случайным образом был сгенерирован следующий массив:");
            for (int i=0;i<mas.GetLength(0);i++) 
                {
                    int j = 0;
                    while ( j!=(mas.GetLength(1)-1)) 
                    {
                        if (mas[i,j]<0 && (mas[i,j])/10==0) Console.Write( mas[i,j]+"  , ");
                        else if (mas[i,j]/10==0) Console.Write(" "+ mas[i,j]+"  , ");
                        else if (mas[i,j]<0 ) Console.Write( mas[i,j]+" , ");
                        else Console.Write(" "+mas[i,j]+" , ");
                        j++;
                    }
                    Console.WriteLine(mas[i,j]);
                }
            Console.WriteLine();
            }

void Rows_summ (int [,] mas)
{
    int Row_sum = 0;
    string[,]  sums = new string[Up+1,2];
            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        Row_sum=Row_sum+mas[i,j];
                    }
                    sums[i,1]=Convert.ToString((Row_sum/Wide));
                    sums[i,0]=Convert.ToString((i+1)) ;
                     Console.Write(sums[i,0]+": ");
                    Console.WriteLine(sums[i,1]);
                }
    int min_sum = Convert.ToInt32( sums[0,1]);
    for (int chelnok=1;chelnok<Up;chelnok++)
    {
        if (Convert.ToInt64(sums[chelnok,1]) < min_sum) min_sum = chelnok ;
    }
    sums[Up,0] = "строка с наименьшей суммой эелементов - ";
    sums[Up,1] =Convert.ToString( min_sum );
    Console.Write(sums[Up,0]+": ");
    Console.WriteLine(sums[Up,1]);


}
try
{
    int [,] rezult = new int[Up,Wide];
    rezult = FillArray(Up,Wide);
    PrintArray(rezult);
    Rows_summ(rezult);
}
catch
{
    Console.WriteLine("oh...somethin wrong");
}