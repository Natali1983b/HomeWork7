// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int CreateRazmerArray (string arg)
{
    System.Console.WriteLine($"Введите {arg}");
    int X = int.Parse(Console.ReadLine());
    return X;
}

int m = CreateRazmerArray("размер m.");
int n = CreateRazmerArray("размер n.");

int[,] CreateArray(int m, int n)
{
    int [,] Array = new int [m,n];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(0, 1000);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
   for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write(Array[i,j]+" " );
        }
        Console.WriteLine();
    } 
}

void AverageOfTheNumbers(int[,] Array)
{
    for (int j = 0; j < Array.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        avarage = (avarage + Array[i, j]);
    }
    avarage = avarage / m;
    Console.WriteLine(avarage + "; ");
}
Console.WriteLine();
    
}


int [,] Array = CreateArray(m,n);
PrintArray(Array);
Console.WriteLine();
AverageOfTheNumbers(Array);
