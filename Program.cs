// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int InputNumber()
{
    int num = new Random().Next(5, 5);
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ChangeRowsToColumns(int[,] arr)
{
    int temp = 0;
    if (arr.GetLength(0) == arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = i; j < arr.GetLength(1); j++)
            {
                
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        }
        PrintArray(arr);
    }
    else Console.WriteLine("No");;
}


int row = InputNumber(), colums = InputNumber();

int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);
Console.WriteLine();
ChangeRowsToColumns(array);