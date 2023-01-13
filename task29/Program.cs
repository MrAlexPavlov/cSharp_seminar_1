// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] CreateArray(int size, int min, int max) //Метод генерации числового массива со случайными элементами в заданных границах
{
    Random rnd = new Random();
    int[] resArray = new int[size];
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(min, max);
    }
    return resArray;
}

string ArrayToString(int[] array) //Метод перевода массива в строку, для дальнейшего вывода на экран
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $"{array[i]}";//Запятую добавляю отдельно, что бы код читался проще
        result = i < (array.Length - 1) ? result + ", " : result; // Если у нас не последний элемент массива то добавляем запятую
    }
    return result + "]";
}


int arraySize = 8, arrayMinValue = 1, arrayMaxValue = 100;//Исходные параметры

int[] randomArray = CreateArray(arraySize, arrayMinValue, arrayMaxValue); //вызываем метод генерации массива
string strArray = ArrayToString(randomArray); //полученный массив переводим в строку

Console.WriteLine(strArray);