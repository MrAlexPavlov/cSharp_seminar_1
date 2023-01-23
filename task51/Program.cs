//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов находящихся на главной диагонали
// с индексами (0,0)(1,1)

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
            result = result + $" {array[i, j],3}";
            result = j < (array.GetLength(1) - 1) ? result + "," : result;//для корректности вывода запятых    
        }

        result += "  ]\n";
    }
    return result;
}

(string formula, int sumElem) SumLeadDiagonalMatrixArray(int[,] matrixArray)//Метода подсчета суммы элементов для главной диагонали
{
    (string formula, int sumElem) result = (formula: "", sumElem: 0);
    int length = matrixArray.GetLength(0) > matrixArray.GetLength(1)
                ? matrixArray.GetLength(1)
                : matrixArray.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        result.formula += $"{matrixArray[i, i]}";
        result.formula += (i < length - 1) ? " + " : "";
        result.sumElem += matrixArray[i, i];
    }
    return result;
}

Console.Clear();
//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 6,
    matrixColSize = 5,
    matrixMinValue = 0,
    matrixMaxValue = 10;

//генерируем массив
int[,] rndMatrixArray = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
//Выводим на массив экран
string rndMatrixString = ArrayToString(rndMatrixArray);
Console.WriteLine(rndMatrixString);

//Получаем сумму элементов диагонали и выводим ее на экран
(string formula, int sumElem) sumLeadDiag;
sumLeadDiag = SumLeadDiagonalMatrixArray(rndMatrixArray);
Console.WriteLine($"{sumLeadDiag.formula} = {sumLeadDiag.sumElem}");