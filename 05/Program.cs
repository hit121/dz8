// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int numIndex = 0;


int[,] matrix = {{22,22,22,22,22,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,22,22,22,22,22}};

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] == 22) Console.Write($"  "); 
            else if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int row, int col)
{

    if (matrix[row, col] == 0)
    {
        matrix[row, col] = numbers[numIndex];
        numIndex++;
        if (matrix[row, col] == 11) FillArray(row - 1, col);
        FillArray(row, col + 1);
        FillArray(row + 1, col);
        FillArray(row, col - 1);
        FillArray(row - 1, col);

    }

}

FillArray(1, 1);
PrintArray(matrix);