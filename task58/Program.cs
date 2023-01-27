// Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreatMatrixRndIntArray(int rowSize, int colSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);

    return resArray;
}

string MatrixToString(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "|";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],2}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }
        result += " |\n";
    }
    return result;
}


int[,] MatrixProd(int[,] arr1, int[,] arr2)
{
    int tmp = 0;
    int sizeRow = arr1.GetLength(0);//количество строк новой матрицы
    int sizeCol = arr2.GetLength(1);//количество столбцов новой матрицы

    int[,] resMatrix = new int[sizeRow, sizeCol];
    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeCol; j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                tmp += arr1[i, k] * arr2[k, j];
            }
            resMatrix[i, j] += tmp;
            tmp = 0;
        }
    }
    return resMatrix;
}


//Параметры для генерации двумерного массива типа int.
int matrix1RowSize = 4,
    matrix1ColSize = 2,
    matrix1MinValue = 1,
    matrix1MaxValue = 9;

//Генерация двумерного массива
int[,] rndMatrix1Int = CreatMatrixRndIntArray(matrix1RowSize, matrix1ColSize, matrix1MinValue, matrix1MaxValue);
Console.WriteLine("Матрица A:");
Console.WriteLine(MatrixToString(rndMatrix1Int));

int matrix2RowSize = 2,
    matrix2ColSize = 2,
    matrix2MinValue = 1,
    matrix2MaxValue = 9;

//Генерация двумерного массива
int[,] rndMatrix2Int = CreatMatrixRndIntArray(matrix2RowSize, matrix2ColSize, matrix2MinValue, matrix2MaxValue);
Console.WriteLine("Матрица B:");
Console.WriteLine(MatrixToString(rndMatrix2Int));

//Произведение 2х матриц
if (rndMatrix1Int.GetLength(1) != rndMatrix2Int.GetLength(0))
{
    Console.WriteLine("Данные матрицы перемножить нельзя.");
    Console.WriteLine("Количество строк первой матрице не равно количеству столбцов второй");
}
else
{
    Console.WriteLine("Произведение матриц A и B:");
    int[,] prod2Matrix = MatrixProd(rndMatrix1Int, rndMatrix2Int);
    Console.WriteLine(MatrixToString(prod2Matrix));
}