// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

        result += " ]\n";
    }
    return result;
}


void MatrixSortByRow(int[,] matrix) //метод сортировки пузырьком
{
    int tmp;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)//определяем кол-во раз прохода по элеметно кажду строку массива
        {
            for (int k = 0; k < matrix.GetLength(1) - j; k++)//Проходим по элемнетам массива
            {
                if (matrix[i, k] < matrix[i, k + 1]) //Если находим что следующий элемент меньше текущего, то меняем их местами
                {
                    tmp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = tmp;
                }
            }
        }
    }
}

//Параметры для генерации двумерного массива типа int.
int matrixRowSize = 4,
    matrixColSize = 4,
    matrixMinValue = -10,
    matrixMaxValue = 10;

int[,] rndMatrixInt = CreatMatrixRndIntArray(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
Console.WriteLine(ArrayToString(rndMatrixInt));

MatrixSortByRow(rndMatrixInt);
Console.WriteLine(ArrayToString(rndMatrixInt));


