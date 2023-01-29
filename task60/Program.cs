// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)



int[,,] Creat3DMatrixRndIntUnique(int xSize, int ySize, int zSize, int minValue, int maxValue)//Метод генерации массива со случайными элементами
{
    int[,,] resArray = new int[xSize, ySize, zSize];
    int[] uniqueArray = new int[maxValue + 1];//временный массив для отслеживания уникальности

    if (minValue < 0 || maxValue < 0) { return resArray; }//Если задан отрицательный диапазон, то возвращаем пустой массив, работаем только с положительными числами
    if ((xSize * ySize * zSize) > (maxValue - minValue + 1)) { return resArray; }//Если количество элементов нового массива больше чем возможных случайных элементов, возвращаем пустой массив

    bool copy = false;
    int newInt = 0;
    Random rnd = new Random();

    for (int x = 0; x < resArray.GetLength(0); x++)
        for (int y = 0; y < resArray.GetLength(1); y++)
            for (int z = 0; z < resArray.GetLength(2); z++)
            {
                while (!copy)//Генерируем число в цикле, до тех пор, пока не найдем уникальное
                {
                    newInt = rnd.Next(minValue, maxValue + 1);
                    if (uniqueArray[newInt] == 0)
                    {
                        copy = true;
                        uniqueArray[newInt]++;//уникальное число записываем во временный массив
                    }
                }
                resArray[x, y, z] = newInt;
                copy = false;
            }

    return resArray;
}


string Matrix3DToString(int[,,] array)//Метод преобразования 3d массива в строку
{
    string result = "";
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
            for (int z = 0; z < array.GetLength(2); z++)
                result = result + $" {array[x, y, z],2}({x},{y},{z})";
        result += "\n";
    }
    return result;
}


//Параметры для генерации трехменрного массива типа int.
int x = 2,
    y = 2,
    z = 2,
    matrixMinValue = 10,
    matrixMaxValue = 99;

//Генерация трехмерного массива с уникальными значениями. 
//Вниманиe! Диапазон выборки значений должен быть больше или равен количеству ячеек нового массива
//Иначе вернет пустой массив
int[,,] rnd3DMatrixInt = Creat3DMatrixRndIntUnique(x, y, z, matrixMinValue, matrixMaxValue);

string text3DMatrix = Matrix3DToString(rnd3DMatrixInt);
Console.WriteLine(text3DMatrix);