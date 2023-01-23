//Задача 49: Задайте двумерный массив. 
//найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты

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

void DoubleValueEvenElemMatrixArray(int[,] matrixArray)//Метода для поиска четных индексов массива и возведение в квадрат их значений
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
        for (int j = 0; j < matrixArray.GetLength(1); j++)
            matrixArray[i, j] *= (i % 2 == 0 && j % 2 == 0) ? matrixArray[i, j] : 1;
}

Console.Clear();
//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 5,
    matrixColSize = 4,
    matrixMinValue = -10,
    matrixMaxValue = 10;

//генерируем массив
int[,] rndMatrixArray = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
//Выводим на массив экран
string rndMatrixString = ArrayToString(rndMatrixArray);
Console.WriteLine(rndMatrixString);
//Возводим в квадрат элементы массива с четными индексами
DoubleValueEvenElemMatrixArray(rndMatrixArray);
//Выводим на массив экран получившийся массив
rndMatrixString = ArrayToString(rndMatrixArray);
Console.WriteLine(rndMatrixString);
