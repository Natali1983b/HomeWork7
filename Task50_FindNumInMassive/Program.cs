// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void FillArray(int[,]Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i,j] = new Random().Next(1,100);
        }
    }
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Console.Write($"{Array[i,j]} ");
           
        }
       Console.WriteLine();
    }
}

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int n = Num("количество строк");
int m = Num("количество столбцов");

int[,] Array = new int[n, m];

FillArray(Array);
PrintArray(Array);

int number = Num("число");

int [,] Number(int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == number) 
            {
               
                Console.WriteLine($"Данное число присутствует в массиве {Array} и находится в {i} строке, {j} столбце");
                return Array;
            }
            
                
            }
        }
        Console.Write("Число не найдено");
        return Array;
    }
    



Number(Array);
