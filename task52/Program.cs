// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreatMatrixRndIntArray(int rowSize, int colSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);

    return resArray;
}

string ArrayToString(int[,] array)//Метод преобразования массива в строку
{
    string result = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += "[";

        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],2}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }

        result += "  ]\n";
    }
    return result;
}

double[] AverageColumnElemMatrix(int[,] array)
{
    double[] resArray = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            resArray[j] += array[i, j];

        resArray[j] = resArray[j] / array.GetLength(0);
        resArray[j] = Math.Round(resArray[j],1);
    }
    return resArray;
}

Console.Clear();
//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 3,
    matrixColSize = 4,
    matrixMinValue = 0,
    matrixMaxValue = 10;

//генерируем массив
int[,] rndMatrixArray = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
//Выводим на массив экран
string rndMatrixString = ArrayToString(rndMatrixArray);
Console.WriteLine(rndMatrixString);

//Считаем среднее по столбцам и выводим на экран.
double[] avgColElemArray = AverageColumnElemMatrix(rndMatrixArray);

string answerMessage = "Среднее арифметическое каждого столбца:\n";
for (int i = 0; i < avgColElemArray.Length; i++)
{
    answerMessage += $"{avgColElemArray[i],2}";
    answerMessage += (i < avgColElemArray.Length - 1) ? "; " : "";
}
Console.WriteLine(answerMessage);