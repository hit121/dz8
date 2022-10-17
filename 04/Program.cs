// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите число высоты массива: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ширины массива: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число глубины массива: ");
int z = Convert.ToInt32(Console.ReadLine());

int[, ,] massiv3D = new int[x,y,z];
string[] numbers =  new string[massiv3D.GetLength(0)*massiv3D.GetLength(1)*massiv3D.GetLength(2)];
int index = 0;

for(int i = 0; i < massiv3D.GetLength(0); i++)
{
    for(int j = 0; j < massiv3D.GetLength(1); j++)
    {
        for (int k = 0; k < massiv3D.GetLength(2); k++)
        {
            massiv3D[i,j,k] = new Random().Next(10, 100);
            while(numbers.Contains(Convert.ToString(massiv3D[i,j,k])))
            {
                massiv3D[i,j,k] = new Random().Next(10, 100);
            }
            numbers[index] = Convert.ToString(massiv3D[i,j,k]);
            index++;
        }
    }
}

void PrintArray(int [, ,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < massiv3D.GetLength(0); k++)
                {Console.Write($"{array[i, j,k]}({i},{j},{k}) ");}
                Console.WriteLine();
            }

        }
    }
PrintArray(massiv3D);
