// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void PrintArrayElement(int[,] array, int line, int column)
{
    if (line > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else
    {
         Console.WriteLine($"Запрашиваемый элемент массива {array[line-1, column-1]}");
    }
}


int[,] array = InputArray(7,7);
Console.WriteLine("Полученный двумерный массив");
PrintArray(array);

Console.WriteLine("Введите номер строки i");
int i = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите номер столбца j");
int j = Convert.ToInt32(Console.ReadLine());

PrintArrayElement(array, i, j);


