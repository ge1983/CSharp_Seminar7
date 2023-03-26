// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] InputArray (int length1, int length2)
{
    int[,] array = new int[length1, length2];
    Random randon = new Random();
    for (int i = 0; i < length1; i++)
    {
        for (int j = 0; j < length2; j++)
        {
            array[i,j] = randon.Next(1, 10);
        }
    }
    return array;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");  
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMeanOfArray(int[,] array)
{
    Console.Write("Среднееаифметическое  элементов в каждом столбце: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];  
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 1)} ");
    }
}


int[,] array = InputArray(7,7);
Console.WriteLine("Полученный двумерный массив");
PrintArray(array);

PrintArithmeticMeanOfArray(array);