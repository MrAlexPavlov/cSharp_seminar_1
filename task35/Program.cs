// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreatArray(int arraySize, int arrayMinValue, int arrayMaxValue)//Метод генерации массива со случайными элементами
{
    int[] resArray = new int[arraySize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = rnd.Next(arrayMinValue, arrayMaxValue + 1);
    }
    return resArray;
}


string ArrayToString(int[] array)//Метод преобразования массива в строку
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result = result + $" {array[i]}";
        result = i < (array.Length - 1) ? result = result + "," : result;//для корректности вывода запятых
    }
    return result + " ]";
}


int CountElements(int[] array, int fMin, int fMax)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= fMin && array[i] <= fMax) result++;
    }
    return result;
}


int arraySize = 123, arrayMinValue = 0, arrayMaxValue = 123, findMin = 10, findMax = 99;

int[] newArray = CreatArray(arraySize, arrayMinValue, arrayMaxValue); //генерируем массив с указаными параметры
string strArray = ArrayToString(newArray);// переводим строку в массив для дальнейшего вывода на экран

int count = CountElements(newArray, findMin, findMax);
Console.WriteLine($"{strArray} -> {count}");