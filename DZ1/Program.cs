// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] InputArray (int length1, int length2)
{
    double[,] array = new double[length1, length2];
    Random randon = new Random();
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i,j] = randon.NextDouble() * 10;
        }
    }
    return array;
}

void PrintArray (double[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i,j], 1)} ");  
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = InputArray(m,n);
Console.WriteLine("Полученный двумерный массив");
PrintArray(array);

