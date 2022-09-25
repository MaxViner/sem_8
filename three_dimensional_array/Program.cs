
Console.WriteLine("ширина массива");
int Wide =  int.Parse(Console.ReadLine());

Console.WriteLine("высота массива");
int Up =  int.Parse(Console.ReadLine());

Console.WriteLine("глубина строк?");
int deep =  int.Parse(Console.ReadLine());

int[,,] FillArray(int Up,int Wide,int deep)
            {
            int[,,] mas = new int[Up,Wide,deep];

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++)
                    {
                        for (int k=0;k<deep;k++)
                        {
                            mas[i,j,k]= new Random().Next(-99,99);
                            //проверка на неповторяемость элементов
                            for (int q=0; q<Up; q++)
                            {
                                for (int t=0;t<Wide;t++)
                                {
                                    for(int r=0;r<deep;r++)
                                    {
                                        if 
                                            (
                                                (mas[i,j,k] == mas[q,t,r])
                                                && i!=q
                                                && j!=t
                                                && r!=k                                     
                                            )
                                        {
                                             k--;
                                        }
                                    
                                    }
                                }
            
                            }
                    }
                }
                }
                
            return mas;
            }
void PrintArray(int[,,] mas)
            {

            for (int i=0;i<Up;i++) 
                {
                    for (int j=0;j<Wide;j++) 
                    {
                    int k = 0;
                    while ( k!=(deep)) 
                    {
                        if (mas[i,j,k]<0 || (mas[i,j,k])/10==0) Console.Write(" "+ mas[i,j,k]+" , "
                        +"("+i+","+j+","+k+")");
                        else if (mas[i,j,k] ==0 ) Console.Write(mas[i,j,k]+"     "+"("+i+","+j+","+k+")");
                        else if (mas[i,j,k]<0 && (mas[i,j,k])/10==0) Console.Write( mas[i,j,k]+" , "
                        +"("+i+","+j+","+k+")");
                        else Console.Write("  "+ mas[i,j,k]+" , "+"("+i+","+j+","+k+")");
                        k++;
                    }
                    
                    Console.WriteLine();
                    }
                }
            Console.WriteLine();
            }

// try
// {
int [,,] rezult = new int[Up,Wide,deep];
rezult = FillArray(Up,Wide,deep);
PrintArray(rezult);
//}
// catch
// {
//     Console.WriteLine("oh... something wrong");
// }

