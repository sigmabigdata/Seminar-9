/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int GetCorrectNumber(string message)
{
    int correctNumber = 0;
    while (true)
    {
        Console.Write($"{message}: ");
        if (int.TryParse(Console.ReadLine(), out correctNumber) && correctNumber > -0)
            return correctNumber;
        else
            Console.WriteLine("Введены ошибочные данные!");

    }
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int sumProductsElements = 0;
    int[,] multipliedMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            sumProductsElements = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                sumProductsElements += matrix1[i, k] * matrix2[k, j];
            }
            multipliedMatrix[i, j] = sumProductsElements;
        }
    }
    return multipliedMatrix;
}



int[,] firstMatrix = new int[,]
    {
        {2, 4},
        {3, 2},
    };
int[,] secondMatrix = new int[,]
    {
        {3, 4},
        {3, 3},
    };
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
{
    int[,] multipliedMatrix = MultiplyMatrices(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение матриц:");
    PrintMatrix(multipliedMatrix);
}
else
{
    Console.Write("Произведение матриц невозможно! ");
    Console.WriteLine("(Число столбцов первой матрицы должно быть равно числу строк второй)");
}