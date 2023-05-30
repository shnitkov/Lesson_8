// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateTwoDimensionArray(int firstLength, int secondLenght)
{
    int[,] array = new int[firstLength, secondLenght];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] array = CreateTwoDimensionArray(6, 6);
Console.ForegroundColor = ConsoleColor.Red;
PrintArray(array);
Console.WriteLine("Исходный двумерный массив");
Console.ForegroundColor = ConsoleColor.White;


int[,] randomArray = CreateTwoDimensionArray(6, 6);
void uporyadok(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

uporyadok(randomArray);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nОтсортированный массив: ");
PrintArray(randomArray);
Console.ForegroundColor = ConsoleColor.White;
