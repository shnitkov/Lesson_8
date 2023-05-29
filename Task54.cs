// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите высоту массива: ");
int firstLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int secondLength = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[firstLength, secondLength];

void mas(int firstLength, int secondLength)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < firstLength; i++)
    {
        for (j = 0; j < secondLength; j++)
        {
            randomArray[i, j] = rand.Next(0, 10);
        }
    }
}

void printm(int[,] array)
{
    int i, j;
    for (i = 0; i < array.GetLength(0); i++)
    { 
        for (j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}

mas(firstLength, secondLength);
Console.WriteLine("\nИсходный массив: ");
printm(randomArray);

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
Console.WriteLine("\nОтсортированный массив: ");
printm(randomArray);
