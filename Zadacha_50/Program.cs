int row = insertNumber("Введите номер строки в массиве:");
int col = insertNumber("Введите номер столбца в массиве:");


if (row<=0 || col<=0 ) Console.WriteLine("Данные введены неправильно.");
else
{
   double [,] desiredArray = createArray();
   printArray(desiredArray);
   if (row > desiredArray.GetLength(0) || col > desiredArray.GetLength(1)) Console.WriteLine("Такого числа в массиве нет.");
   else Console.WriteLine($"Искомое число: {desiredArray[row-1,col-1]}");
}



//Метод ввода данных
int insertNumber (string message)
{
    Console.WriteLine(message);
int number = int.Parse(Console.ReadLine());
return number;
}

//Метод ввода массива
double [,] createArray()
{
    int n = new Random().Next(1,20);
    int m = new Random().Next(1,20);
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

