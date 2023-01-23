// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] CreatMatrixRndDoubleArray(int rowSize, int colSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
{
    double[,] resArray = new double[rowSize, colSize];
    Random rnd = new Random();
    double tmp;

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            tmp = rnd.NextDouble() * (maxValue - minValue) + minValue;
            resArray[i, j] = Math.Round(tmp, 1);
        }

    return resArray;
}

string ArrayDoubleToString(double[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],4}";
            result = j < (array.GetLength(1) - 1) ? result + " " : result;//для корректности вывода запятых    
        }

        result += "]\n";
    }
    return result;
}

//Параметры для генерации двумерного массива типа double.
int matrixRowSize = 3,
    matrixColSize = 4,
    matrixMinValue = -10,
    matrixMaxValue = 10;

double[,] rndMatrixArray = CreatMatrixRndDoubleArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);

string rndMatrixString = ArrayDoubleToString(rndMatrixArray);
Console.Clear();
Console.WriteLine(rndMatrixString);