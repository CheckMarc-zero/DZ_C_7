int n = insertNumber("Введите колличество строк в массиве:");
int m = insertNumber("Введите колличество столбцов в массиве:");


if (n<=0 || m<=0 ) Console.WriteLine("Данные введены неправильно.");
else
{
   double [,] desiredArray = createArray(n,m);
   printArray(desiredArray);
}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод ввода массива
double [,] createArray(int n, int m)
{
    double [,] a = new double [n,m];
    for (int row = 0; row < n ; row++)
    {
       for (int col = 0; col < m ; col++) 
       {
        a[row,col] = Math.Round((new Random().NextDouble()*100),2);
       }
    }
    return a;
}

//Метод вывода массива
void printArray( double[,] array)
{
    for (int row = 0; row < array.GetLength(0) ; row++)
    {
       for (int col = 0; col < array.GetLength(1) ; col++) 
       {
        Console.Write($"{array[row,col]}  ");
       }
       Console.WriteLine();
    }
}