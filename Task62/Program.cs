/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j].ToString("00")} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[4, 4];

for (int i = 1; i < 5; i++)
    matrix[0, i - 1] = i;
for (int i = 5; i < 8; i++)
    matrix[i - 4, 3] = i;
for (int i = 8; i < 11; i++)
    matrix[3, 10 - i] = i;
for (int i = 11; i < 13; i++)
    matrix[13 - i, 0] = i;
for (int i = 13; i < 15; i++)
    matrix[1, i - 12] = i;
for (int i = 15; i < 17; i++)
    matrix[2, 17 - i] = i;

PrintMatrix(matrix);