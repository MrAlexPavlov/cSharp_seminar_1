//Задача 48: Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Amn = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5

int[,] CreatMatrixIntArray(int rowSize, int colSize)//Метод создания массива value = i+j
{
    int[,] resArray = new int[rowSize, colSize];

    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = i+j;

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

        result += " ]\n";
    }
    return result;
}

//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 4,
    matrixColSize = 4;

int[,] newMatrixArray = CreatMatrixIntArray(matrixRowSize, matrixColSize);

string newMatrixString = ArrayToString(newMatrixArray);
Console.Clear();
Console.WriteLine(newMatrixString);
