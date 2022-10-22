int n = insertNumber("Введите колличество строк в массиве:");
int m = insertNumber("Введите колличество столбцов в массиве:");
int min = insertNumber("Введите минимальное значение членов массива:");
int max = insertNumber("Введите максимальное значение членов массива:");
Console.WriteLine();

if (n<=0 || m<=0 || min>max) Console.WriteLine("Данные введены неправильно.");
else
{
   int [,] desiredArray = createArray(n,m,min,max);
   printArray(desiredArray);
   Console.WriteLine();
  double[] desiredNumbers = srednArif(desiredArray);
 for(int i=0; i< desiredNumbers.Length;i++) Console.WriteLine($"Среднее арифметическое столбца {i+1}: {desiredNumbers[i]}");
}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод ввода массива
int [,] createArray(int n, int m, int min, int max)
{
    int [,] a = new int [n,m];
    for (int row = 0; row < n ; row++)
    {
       for (int col = 0; col < m ; col++) 
       {
        a[row,col] = new Random().Next(min,max+1);
       }
    }
    return a;
}

//Метод вывода массива
void printArray( int[,] array)
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
//Метод вычисления среднего арифметического столбцов
double [] srednArif( int [,] massiv)
{
   double [] sredn = new double[massiv.GetLength(1)];
   double result = 0;
   for (int i = 0; i< massiv.GetLength(1);i++)
   {
    for(int j = 0; j< massiv.GetLength(0);j++)
    {
        result = result + massiv[j,i];
    }
    sredn[i] = Math.Round((result/massiv.GetLength(0)),2);
    result = 0;
   }
   return sredn;
}

