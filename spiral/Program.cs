
Console.WriteLine("размерность массива");
int Wide =  int.Parse(Console.ReadLine());
int Up;
Up=Wide;

int[,] Saw9(int Up,int Wide)
{
        int direction;
        direction = 1;
        int summ;
        int rounds;
        rounds=0;
        summ=0;
        int i;
        int j;
        i=0;
        j=0;
        int[,] mas = new int[Up,Wide]; 

        for (int count=1;count<=(Wide*Wide/4+1);count++)
        {
            //Console.WriteLine(count);
            
            if (direction == 1)
            {
               // Console.Write(direction);
                while (j <= Wide-rounds-1)
                {
                    summ = summ+1;
                    mas[i,j]=summ;
                    j++;
                }
                direction = 2;
                   j--;
                   summ--;
            }

             if (direction==2)
            {
                //Console.Write(direction);
                 while (i<=(Up-1-rounds))
            {
                summ = summ+1;
                mas[i,j]= summ ;
                i++;
            }
                i--;
                summ--;
            direction = 3;
            }
            else if (direction==3)
        {
        while (j>=rounds)
            {
                summ = summ+1;
                mas[i,j]=summ;
                j--;
            }
            j++;
            rounds++;
            summ--;
            direction = 4;
        }
            else if (direction==4)
    {
        while (i>=rounds)
            {
                summ = summ+1;
                mas[i,j]= summ;
                i--;
            }
            direction = 1;
            i++;
            summ--;
        }
   
    }  

return mas;
}
void PrintArray(int[,] mas)
            {

            for (int i=0;i<Up;i++) 
                {
                    int j=0;
                    while ( j!=(Wide-1)) 
                    {
                       
                         if ( (mas[i,j])/10==0) Console.Write( mas[i,j]+"  , ");
                        else Console.Write( mas[i,j]+" , ");
                        j++;
                    }
                    Console.WriteLine(mas[i,j]);
                }
            Console.WriteLine();
            }

try
{
int [,] rezult = new int[Up,Wide];
rezult = Saw9(Up,Wide);
PrintArray(rezult);
}
catch
{
    Console.WriteLine("oh... something wrong");
}

