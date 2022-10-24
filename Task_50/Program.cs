//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

Console.Write("Введите необходимую строку массива: ");
int neededRow = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите необходимый столбец массива: ");
int neededColumn = int.Parse(Console.ReadLine() ?? "");

GetNeededValue(array, neededRow, neededColumn);


//................................МЕТОДЫ.................................

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}


void GetNeededValue(int[,] inArray, int neededRow, int neededColumn)
{
    if (neededRow -1 < array.GetLength(0) && neededColumn -1 < array.GetLength(1))
    {
        int x = inArray[neededRow -1, neededColumn -1];
        Console.WriteLine($"Значение элемента массива: {x}");
    }
    else Console.WriteLine($"[{neededRow},{neededColumn}] -> Такого элемента в массиве нет");
}