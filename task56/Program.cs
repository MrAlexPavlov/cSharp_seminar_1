// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 

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
        result += "[";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result = result + $" {array[i, j],2}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }
        result += " ]\n";
    }
    return result;
}

int[] SumOfMatrixRowElem(int[,] matrix)
{
    int[] resArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resArray[i] += matrix[i, j];
        }
    }
    return resArray;
}

(string text, int minRowValue) FindMinimalSumRowElem(int[,] matrix)//Метод преобразования массива в строку
{
    int[] array = SumOfMatrixRowElem(matrix);
    
    (string text, int minRowValue) result = (text:String.Empty, minRowValue:0);
    int min = array[result.minRowValue];

    result.text = $" Сумма элементов 0 строки : {array[0],3}\n";
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            result.minRowValue = i;
        }
        result.text += $" Сумма элементов {i} строки : {array[i],3}\n";
    }
    result.text = $"{result.minRowValue} строка в матрице с наименьшей суммой элементов\n\n" + result.text;
    return result;
}

//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 4,
    matrixColSize = 4,
    matrixMinValue = -9,
    matrixMaxValue = 9;

//Генерация двумерного массива
int[,] rndMatrixInt = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
Console.WriteLine(MatrixToString(rndMatrixInt));

//поиск строки в двумерном массиве с наименьшей суммой элементов.
//возращает полный текст для ответа и номер строки
var answer = FindMinimalSumRowElem(rndMatrixInt);
Console.WriteLine(answer.text);