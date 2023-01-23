// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

int[] UserEnteredNumbers(string text, char delim)//Метод пользовательского ввода нескольких чисел через разделитель delim
{
    bool tryParseToInt;
    int j = 0, intTmp = 0;
    //ожидаем пользовательского ввода
    Console.WriteLine(text);
    string usersText = Console.ReadLine() ?? string.Empty;

    //преобразуем строку в строковый массив и переводим его в числовой массив
    string[] tmpStrArray = usersText.Split(delim);
    int[] tmpArray = new int[tmpStrArray.Length];
    for (int i = 0; i < tmpStrArray.Length; i++)
    {
        //Берем только числовые значения
        tryParseToInt = Int32.TryParse(tmpStrArray[i], out intTmp);
        if (tryParseToInt) tmpArray[j++] = intTmp;
    }
    //Если размер нового числого массива будет больше чем количество вписанных туда элементов 
    //Например: не все, что ввел пользователь было числами, задвоение разделеителей и т.п.
    //то удаляем не нужное через создание другого массива

    int[] resArray = new int[j];
    if (tmpArray.Length > j)
    {
        for (int i = 0; i < resArray.Length; i++)
            resArray[i] = tmpArray[i];
    }
    else resArray = tmpArray;

    if (resArray.Length!=2) resArray = UserEnteredNumbers(text, delim);//Если пользователь ввел что-то не то, просим это сделать еще раз
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

int[] usersNum = UserEnteredNumbers("Введите номер строки и номер столбца через запятую:", ',');
//Проверяем элемент на существование по номерам индекса
string answer;
if (usersNum[0] > rndMatrixArray.GetLength(0) || usersNum[1] > rndMatrixArray.GetLength(1))
    answer = "Такого элемента нет!";
else
    answer = $"{rndMatrixArray[usersNum[0], usersNum[1]]}";

Console.WriteLine($"{usersNum[0]}, {usersNum[1]} - > {answer}");